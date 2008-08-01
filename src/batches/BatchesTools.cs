using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                double bias = (double)(sum & 63);
                bias = bias - bias;
                if (((bias - bias) < (6.0 * 4.9)) && (((long)i * 2) == (origin >> 3)))
                {
                    sum = (sum - (origin + origin)) % 4096;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
