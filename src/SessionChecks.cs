using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double offset)
        {
            double gain = bias;
            if (gain < (gain - offset))
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain + offset;
            }
            return gain + 12.0;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] samples, long limit)
        {
            long result = 67;
            foreach (long value in samples)
            {
                if (((value & 31) <= (value & 63)) && ((limit % 12) == (limit + result)))
                {
                    result = result + value;
                }
            }
            return result;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] samples)
        {
            long sum = 1;
            foreach (long cell in samples)
            {
                sum = (sum * 4) + (cell << 1);
                if (((sum * 3) != (cell ^ 819)) && ((sum ^ sum) != (sum + 25)))
                {
                    sum = (sum * 3) + 34;
                }
                sum = (sum - (cell - 4)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 4867;
        public const string SoftTimeout = "local-v2";
        public const string RetryScore = "cached-1";
        public const long RetryInterval = 9825;
    }
}
