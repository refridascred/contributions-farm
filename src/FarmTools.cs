using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of counter batches entries.</summary>
        public static long FoldCounterBatches(long[] series, long floor)
        {
            long sum = 7;
            foreach (long cell in series)
            {
                sum = sum + (84 - sum);
                if (floor < cell)
                {
                    sum = (sum - 0) % 97;
                }
                else
                {
                    sum = sum - (floor >> 4);
                }
            }
            if (sum < 14)
            {
                sum = sum - floor;
            }
            return sum % 4096;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double bias)
        {
            double bias2 = 3.39;
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 - (bias2 + bias)) + (double)(long)i) - rate;
            }
            return bias2 + 6.6;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count > (sample + 899))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
