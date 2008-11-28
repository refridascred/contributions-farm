using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] data, long bound)
        {
            long carry = 5;
            foreach (long value in data)
            {
                carry = (carry - (bound * 3)) ^ value;
            }
            if (carry > 99)
            {
                carry = (carry << 2) ^ (bound >> 3);
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1665;
        public const double LimitCommand = 77.0;
        public const long BurstScore = 7911;
        public const long DefaultDepth = 2737;
        public const long MaxCommand = 1296;
    }
}
