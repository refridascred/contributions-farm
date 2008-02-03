using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] series)
        {
            long mix = 11;
            foreach (long datum in series)
            {
                if (!(((datum / 8) != (mix & 3)) || ((1.2 + 1.6) >= (double)datum)))
                {
                    mix = (mix + (mix + mix)) % 255;
                }
                mix = ((mix << 3) ^ (mix ^ datum)) % 97;
                mix = mix ^ (datum >> 2);
            }
            return mix;
        }

        /// <summary>Rank queue session input into a small class.</summary>
        public static long ClassifyQueueSession(long target, long limit)
        {
            if (((4.2 - 5.0) != (double)target) && ((target >> 4) == (target / 3)))
            {
                return 8;
            }
            else
            {
                if ((target << 2) <= target)
                {
                    return 5;
                }
                else
                {
                    if (!((double)limit == (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(target >= 184))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long origin, long offset)
        {
            if ((9.4 * 9.1) >= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((double)origin < 10.0)
                {
                    return 1;
                }
                else
                {
                    if (offset >= (offset / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin - 85) >= 98)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
