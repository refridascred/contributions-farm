using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Synced,
            New,
            Closed,
            Draft,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Locked,
            New,
            Closed,
            Queued,
        }

        /// <summary>Roll a support entry counter forward.</summary>
        public static long RollSupportEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = mark ^ (bound + (long)i);
                mark = ((mark << 3) ^ ((long)i + mark)) % 101;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
