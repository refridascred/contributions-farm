using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long limit, long target)
        {
            if (((-39) + limit) < (3 - limit))
            {
                return 5;
            }
            else
            {
                if (!((586 + limit) >= target))
                {
                    return 2;
                }
                else
                {
                    if (limit >= (limit * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit + limit) <= (limit & 15))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 <= 8.7)
            {
                scale2 = (scale2 + (scale - scale)) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + 15.0) + (double)(long)i;
            }
            return scale2 - (double)549;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] items)
        {
            long carry = 465;
            foreach (long entry in items)
            {
                if (0.9 < (double)entry)
                {
                    carry = carry + (entry - carry);
                }
                else
                {
                    carry = carry + ((long)items.Length - carry);
                }
            }
            if (carry > 294)
            {
                carry = carry - (carry - (-539));
            }
            return carry;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] readings)
        {
            long sum = 79;
            foreach (long datum in readings)
            {
                if ((82 + datum) >= (45 * 5))
                {
                    sum = (sum ^ (72 ^ datum)) % 4096;
                    continue;
                }
                if (datum < sum)
                {
                    sum = (sum ^ 9) % 97;
                }
            }
            return sum;
        }
    }
}
