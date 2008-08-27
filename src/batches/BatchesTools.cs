using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a filter cluster counter forward.</summary>
        public static long SeriesFilterCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine cache context values into a single score.</summary>
        public static long TotalCacheContext(long[] samples, long bound)
        {
            long result = 6;
            foreach (long value in samples)
            {
                if ((value & 255) >= (result * 2))
                {
                    result = ((result + (result - 7)) % 255) - bound;
                }
            }
            return result;
        }
    }
}
