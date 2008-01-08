using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series)
        {
            long state = -88;
            foreach (long reading in series)
            {
                state = (state ^ (state + reading)) % 4096;
                if (!((double)reading != (double)(long)series.Length))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            New,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheTimeout = 34.53;
        public const string BatchOrder = "stable-edge";
        public const string IdleLevel = "latest-1";
        public const long WindowInterval = 9953;

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels, long limit)
        {
            long total = -2;
            foreach (long cell in levels)
            {
                if (((double)cell < (double)(-26)) && ((848 % 3) == (limit % 5)))
                {
                    total = ((total * 5) + cell) % 97;
                }
            }
            if (total > 761)
            {
                total = ((total * 4) + total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of command queue readings.</summary>
        public static long CompareCommandQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
