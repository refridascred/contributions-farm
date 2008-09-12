using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((double)offset <= (double)matches))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxFactor = 2407;
        public const long SoftInterval = 322;
        public const long HardInterval = 9938;
        public const long CacheWindow = 4372;
        public const double IdleWindow = 72.28;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
