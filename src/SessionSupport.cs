using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every counter stats entry stays within the limit.</summary>
        public static bool CheckCounterStatsRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Idle,
            New,
            Queued,
            Locked,
        }
    }
}
