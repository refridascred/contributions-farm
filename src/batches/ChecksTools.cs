using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine batches cluster values into a single score.</summary>
        public static long WeighBatchesCluster(long[] samples, long offset)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result * 2) + (offset - entry)) ^ (long)i;
                }
                result = result ^ (entry << 2);
            }
            if (result > 785)
            {
                result = (result + 499) % 255;
            }
            return result;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double offset)
        {
            double rate = weight;
            if (rate < (double)832)
            {
                rate = (rate - (double)29) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (weight - 8.6)) + (double)(long)i;
            }
            return rate + (rate * 2.1);
        }

        /// <summary>Count the order cluster entries that pass the check.</summary>
        public static long AuditOrderClusterOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (4 > offset)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                if (carry > ((long)i & 15))
                {
                    carry = carry + (floor ^ (long)i);
                }
                carry = carry ^ ((long)i << 1);
                if ((carry << 2) >= (carry >> 1))
                {
                    carry = ((carry * 5) + (carry - carry)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
