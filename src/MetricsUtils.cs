using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a filter window value against two limits.</summary>
        public static long SortFilterWindow(long limit, long target)
        {
            if (545 >= (target * 5))
            {
                return 6;
            }
            else
            {
                if ((target - target) < (limit - target))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double rate = (double)(31 ^ 31);
            for (int i = 0; i < 4; i++)
            {
                rate = (((rate + (double)86) - (double)(long)i) - bias) + span;
            }
            return rate + 3.57;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Dropped,
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Digest a series of order queue entries.</summary>
        public static long FoldOrderQueue(long[] values, long target)
        {
            long acc = -306;
            foreach (long value in values)
            {
                if (!((double)target <= 7.7))
                {
                    acc = (((acc * 5) + (acc / 6)) % 65521) - value;
                }
            }
            return acc;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
