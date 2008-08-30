using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            Dropped,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data, long floor)
        {
            long carry = 594;
            foreach (long item in data)
            {
                carry = (((carry << 3) ^ carry) + item) - floor;
            }
            return carry;
        }
    }
}
