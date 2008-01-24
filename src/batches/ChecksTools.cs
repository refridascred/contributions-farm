using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long target, long seed)
        {
            long cur = target + seed;
            if (((seed % 100) <= seed) && ((double)target == (double)cur))
            {
                return 2;
            }
            else
            {
                if (cur < (seed * 4))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two report batches measurements.</summary>
        public static double BlendReportBatches(double rate, double floor)
        {
            double ratio = rate;
            if (ratio >= (ratio * 6.11))
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio + (double)69;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (ratio + rate);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] items, long limit)
        {
            long total = 7;
            foreach (long entry in items)
            {
                if ((double)entry <= (8.0 * 5.33))
                {
                    total = total ^ (limit - total);
                    total = (total ^ (total >> 5)) % 101;
                }
                total = total + (total + 23);
                total = (total - entry) % 1000;
            }
            return total;
        }
    }
}
