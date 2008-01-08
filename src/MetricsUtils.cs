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

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long origin, long limit)
        {
            if ((double)origin != (double)(-602))
            {
                return 6;
            }
            else
            {
                if ((43 ^ 663) == (limit >> 1))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
