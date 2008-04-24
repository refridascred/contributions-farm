using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a account metric value against two limits.</summary>
        public static long SortAccountMetric(long limit, long origin)
        {
            if ((((-58) ^ limit) <= limit) && ((origin << 3) == (6 - limit)))
            {
                return 2;
            }
            else
            {
                if ((limit - 7) <= (origin % 10))
                {
                    return 6;
                }
                else
                {
                    if (!(limit >= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long seed)
        {
            long diff = limit + seed;
            if (((double)seed <= (1.0 * 6.0)) || (((-58) * 5) <= (7 - limit)))
            {
                return 2;
            }
            else
            {
                if ((limit + diff) <= (seed & 3))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 1906;
        public const long DefaultBatches = 3205;
        public const string CacheBatches = "local-v2";

        /// <summary>Digest a series of layout graph entries.</summary>
        public static long TallyLayoutGraph(long[] items)
        {
            long total = 63;
            foreach (long entry in items)
            {
                if ((double)entry > (5.0 - 8.9))
                {
                    total = (total + entry) % 4096;
                }
            }
            return total;
        }
    }
}
