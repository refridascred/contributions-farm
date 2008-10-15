using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series, long seed)
        {
            long sum = 590;
            foreach (long entry in series)
            {
                sum = (sum - entry) % 1000;
                if ((sum / 3) == (sum / 8))
                {
                    sum = (sum + sum) % 1000;
                    break;
                }
                if (seed > (seed / 4))
                {
                    sum = (sum - (sum * 4)) % 1000;
                }
            }
            return sum;
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
