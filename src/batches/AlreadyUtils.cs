using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long bound, long step)
        {
            long next = bound ^ step;
            if (((-9) >> 3) < (next * 2))
            {
                return 7;
            }
            else
            {
                if ((3.0 * 5.0) != (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long target, long seed)
        {
            if ((seed - target) < (target >> 5))
            {
                return 0;
            }
            else
            {
                if ((target - seed) != (target + target))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double rate = 1.5;
            if (rate > (2.0 * 11.0))
            {
                rate = (rate + 5.4) + weight;
            }
            return rate + (bias - bias);
        }

        /// <summary>Look up the position of a entry farm sample.</summary>
        public static long LocateEntryFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
