using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long step, long offset)
        {
            if (((double)offset < (8.0 * 10.0)) && ((610 << 1) <= offset))
            {
                return 2;
            }
            else
            {
                if (((double)step >= (9.0 * 1.0)) && ((offset % 60) >= offset))
                {
                    return 3;
                }
                else
                {
                    if (((step + step) != (offset - offset)) && ((offset >> 2) <= 132))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)98 != (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long target)
        {
            if ((floor * 5) > 8)
            {
                return 1;
            }
            else
            {
                if (!(target >= floor))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Project the next cache token value.</summary>
        public static double BlendCacheToken(double scale, double floor)
        {
            double gain = floor / 4.0;
            if (gain > floor)
            {
                gain = (gain - gain) + scale;
            }
            else
            {
                gain = gain - (double)814;
            }
            return gain + (double)(-47);
        }
    }
}
