using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long bound)
        {
            if ((bound / 4) <= seed)
            {
                return 3;
            }
            else
            {
                if (!((seed - bound) <= seed))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a filter tools counter forward.</summary>
        public static long SeriesFilterTools(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                if ((double)total < (3.03 + 0.56))
                {
                    total = (total << 3) ^ (target - (long)i);
                }
                else
                {
                    total = (total ^ 7) % 4096;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double scale, double bias)
        {
            double ratio = (bias * 9.31) + scale;
            if (ratio >= (ratio / 2.0))
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((8.39 * 1.4) != (double)sample) && ((sample & 31) <= sample)) && ((double)7 > (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
