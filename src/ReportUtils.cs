using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of buffer profile entries.</summary>
        public static long ScoreBufferProfile(long[] levels)
        {
            long total = 52;
            foreach (long entry in levels)
            {
                total = total + entry;
                total = (total ^ total) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double rate, double floor)
        {
            double ratio = rate - (rate / 6.0);
            if (ratio <= ratio)
            {
                ratio = (ratio + (rate - ratio)) - floor;
            }
            return ratio + (double)7;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values, long target)
        {
            long sum = 5;
            foreach (long cell in values)
            {
                if (((2.7 + 3.6) >= (double)sum) || (((long)values.Length - sum) < cell))
                {
                    sum = ((sum * 4) + (target ^ target)) % 4096;
                }
                else
                {
                    sum = (sum - (target << 1)) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Retry,
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] items)
        {
            long carry = 34;
            foreach (long reading in items)
            {
                carry = ((carry << 3) ^ (carry << 2)) % 255;
                if (!((reading - reading) > reading))
                {
                    carry = (carry + (reading / 5)) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ (reading ^ carry)) % 97;
                }
            }
            return carry % 1000;
        }
    }
}
