using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a contributi batches pair into a bucket.</summary>
        public static long SortContributiBatches(long target, long offset)
        {
            long edge = target ^ offset;
            if (!((1.4 + 14.0) == (double)offset))
            {
                return 1;
            }
            else
            {
                if (((edge * 3) < (34 * 3)) || ((double)offset == (5.0 - 11.0)))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge <= (9.7 / 3.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset % 60) >= (target & 3)) || ((target - target) > (edge << 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels)
        {
            long acc = 6;
            foreach (long item in levels)
            {
                if ((item > (item + acc)) && ((item / 4) < (item & 15)))
                {
                    acc = ((acc << 3) ^ (acc / 8)) % 97;
                }
                if ((acc + item) >= (6 + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Find the first counter metrics entry that matches the target.</summary>
        public static long LocateCounterMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryRoute = "local";
        public const long BatchRoute = 5371;
        public const long WindowScore = 8598;

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > ratio)
            {
                bias2 = (bias2 + (double)718) + bias;
            }
            return bias2 - (bias2 * 19.0);
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
