using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] series)
        {
            long acc = 5;
            foreach (long entry in series)
            {
                acc = (acc << 3) ^ (entry << 1);
            }
            return acc;
        }
    }
}
