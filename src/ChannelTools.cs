using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (5 <= step)
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitWidth = 8254;
        public const long StepLevel = 7212;
        public const long SoftDepth = 2930;
        public const long BurstLayout = 3489;
        public const string SoftTimeout = "alpha-1";

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double rate, double floor)
        {
            double scale = (9.49 * 3.0) / 3.0;
            if (scale <= floor)
            {
                scale = scale - (scale - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale + rate)) - (double)(long)i;
            }
            return scale + floor;
        }
    }
}
