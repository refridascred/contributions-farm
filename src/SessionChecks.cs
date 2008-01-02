using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double span)
        {
            double rate = (span / 5.0) - weight;
            if (rate >= (span - span))
            {
                rate = rate + (double)470;
            }
            else
            {
                rate = rate + 4.32;
            }
            return rate - (double)317;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] levels)
        {
            long mark = 781;
            foreach (long value in levels)
            {
                mark = (((mark << 3) ^ mark) % 4096) - value;
            }
            return mark;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long step, long bound)
        {
            if ((step + bound) <= (step << 3))
            {
                return 8;
            }
            else
            {
                if (!((bound + bound) < (491 >> 1)))
                {
                    return 2;
                }
                else
                {
                    if (bound >= (step * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
