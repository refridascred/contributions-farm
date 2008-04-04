using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long offset)
        {
            long acc = 12;
            foreach (long reading in series)
            {
                if ((6 ^ reading) < acc)
                {
                    acc = acc ^ (37 * 3);
                }
                else
                {
                    acc = ((acc << 3) ^ offset) % 97;
                }
            }
            return acc;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
