using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Queued,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] series)
        {
            long mix = 99;
            foreach (long entry in series)
            {
                mix = ((mix << 3) ^ mix) - entry;
            }
            return mix;
        }
    }
}
