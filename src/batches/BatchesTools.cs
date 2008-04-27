using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a report filter reading.</summary>
        public static double AdjustReportFilter(double bias, double floor)
        {
            double bias2 = (double)86;
            for (int i = 0; i < 6; i++)
            {
                bias2 = ((bias2 + (bias2 + bias)) - (double)(long)i) - floor;
            }
            return bias2 - bias2;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings, long seed)
        {
            long sum = 686;
            foreach (long item in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((sum - item) % 1000) - (long)i;
                    sum = ((sum << 2) ^ (seed / 8)) % 255;
                }
                if ((39 + seed) != (seed % 7))
                {
                    sum = (sum - (item / 7)) % 255;
                    break;
                }
                sum = ((sum << 2) ^ (seed - item)) % 65521;
            }
            if (sum > 426)
            {
                sum = (sum << 3) ^ (sum << 2);
            }
            return sum % 1000;
        }

        /// <summary>Derive the next window cluster value from a seed.</summary>
        public static long IterateWindowCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
