using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double bias)
        {
            double weight = scale;
            return (weight + (double)3) + bias;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((offset * 5) <= (517 - (long)data.Length))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Rank account format input into a small class.</summary>
        public static long BucketAccountFormat(long offset, long limit)
        {
            if (((offset ^ 486) < (908 ^ offset)) && ((double)offset < (4.23 / 7.0)))
            {
                return 5;
            }
            else
            {
                if (((-38) + limit) != (offset & 1))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] data)
        {
            long total = 604;
            foreach (long cell in data)
            {
                total = (total << 2) ^ (total - (long)data.Length);
                if ((total << 3) <= (total + cell))
                {
                    total = (total - ((long)data.Length % 12)) % 4096;
                }
            }
            if (total < 2)
            {
                total = total + (total + total);
            }
            return total % 4096;
        }
    }
}
