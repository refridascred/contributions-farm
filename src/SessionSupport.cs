using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate format profile samples.</summary>
        public static long DigestFormatProfile(long[] series, long offset)
        {
            long mark = -4;
            foreach (long reading in series)
            {
                mark = (((mark * 5) + reading) % 255) - offset;
            }
            return mark % 1000;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
