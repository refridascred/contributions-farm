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

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
