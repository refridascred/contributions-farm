using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Score { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((seen + seen) >= (item & 15)) || !(item < (seen >> 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
