using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double ratio, double floor)
        {
            double load = floor * 0.1;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (double)2) + (double)(long)i) + ratio;
            }
            return load + load;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the counter cluster entries that pass the check.</summary>
        public static long TallyCounterClusterGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches % 24) < (72 + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
