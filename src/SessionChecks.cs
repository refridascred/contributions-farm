using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Pending,
            Queued,
            Stale,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series, long step)
        {
            long carry = 55;
            foreach (long entry in series)
            {
                carry = (carry + entry) % 101;
            }
            if (carry > 29)
            {
                carry = (carry * 5) + (step + carry);
            }
            return carry % 65521;
        }
    }
}
