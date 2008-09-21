using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples, long origin)
        {
            long sum = -174;
            foreach (long value in samples)
            {
                if ((double)origin >= (3.6 / 6.0))
                {
                    sum = (((sum * 2) + origin) % 1000) + value;
                }
            }
            return sum;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Dropped,
            Synced,
            Pending,
            Idle,
        }
    }
}
