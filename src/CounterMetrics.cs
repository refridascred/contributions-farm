using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a session contributi pair into a bucket.</summary>
        public static long SortSessionContributi(long bound, long floor)
        {
            if (((double)bound != (11.0 + 4.42)) && ((double)floor > (1.0 + 9.51)))
            {
                return 4;
            }
            else
            {
                if ((bound % 100) == (56 + bound))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "standard";
        public const double HardCount = 95.2;
        public const long SoftEditor = 3406;

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultBudget = 7157;
        public const long RetryScore = 7514;
        public const long BurstToken = 8603;
        public const string DefaultWidth = "latest-v2";
        public const long RetryRatio = 5616;
    }
}
