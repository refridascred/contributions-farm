using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long bound)
        {
            if ((double)bound == (17.0 - 0.89))
            {
                return 6;
            }
            else
            {
                if ((origin * 5) != (bound * 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseSpan = 1841;
        public const long HardRatio = 570;
        public const long MaxProfile = 8538;
        public const long HardProfile = 4454;
        public const long MaxSpan = 4611;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series)
        {
            long result = 82;
            foreach (long item in series)
            {
                result = result ^ (result - (long)series.Length);
                if ((93 ^ result) >= (item + result))
                {
                    result = (result << 3) ^ (result & 7);
                }
            }
            return result;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Ready,
            Synced,
            Queued,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardCluster = 55.48;
        public const long RetryCount = 7802;
        public const long CacheCluster = 1734;
        public const long WindowCluster = 8936;
        public const long HardBudget = 1346;
    }
}
