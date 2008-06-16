using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Idle,
            Ready,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit window commits readings against a rule.</summary>
        public static long CountWindowCommitsMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell / 2) == (offset + 0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
