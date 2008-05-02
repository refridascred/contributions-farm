using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally * 2) >= (tally / 3))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchSpan = 128;
        public const double RetryQueue = 95.0;
        public const string CacheInterval = "open-edge";
        public const long BaseWidth = 5520;
    }
}
