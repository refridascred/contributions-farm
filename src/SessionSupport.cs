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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches / 7) <= (42 << 3))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
