using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long bound, long target)
        {
            if ((target - 15) > (bound + target))
            {
                return 8;
            }
            else
            {
                if (((double)bound < (double)target) || (bound <= (bound + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((834 << 3) != (bound ^ target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound > (bound + (-58)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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

        /// <summary>Count the context cluster entries that pass the check.</summary>
        public static long CountContextClusterHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (8 < (hits + hits))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
