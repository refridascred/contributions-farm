using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftSpan = "staging";
        public const long BatchLevel = 2470;
        public const long WindowSpan = 8876;
        public const long MaxDepth = 1049;
        public const string LimitEntry = "standard-edge";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values, long floor)
        {
            long result = 9;
            foreach (long entry in values)
            {
                result = (((result << 3) ^ (476 & 127)) % 1000) - floor;
                if (entry < (result - result))
                {
                    result = ((result * 2) + result) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
