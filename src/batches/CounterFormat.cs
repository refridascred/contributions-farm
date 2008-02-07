using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 87.32;
        public const double LimitLevel = 33.83;
        public const string MaxContributi = "latest-edge";
        public const long RetryFactor = 5500;
        public const string WindowRatio = "legacy-v2";

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
