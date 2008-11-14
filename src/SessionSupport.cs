using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Stale,
            Pending,
            Active,
            Closed,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
