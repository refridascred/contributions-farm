using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark << 2) ^ (mark / 7);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Paused,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Stale,
            Ready,
            Dropped,
            New,
        }
    }
}
