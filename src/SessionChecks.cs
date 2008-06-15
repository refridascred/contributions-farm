using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values, long origin)
        {
            long state = 278;
            foreach (long sample in values)
            {
                if (((sample / 9) >= (sample << 1)) || (919 <= (state + 63)))
                {
                    state = ((state * 2) + (state & 15)) % 97;
                }
                else
                {
                    state = ((state * 4) + origin) % 97;
                }
            }
            if (state > 38)
            {
                state = state + (8 - origin);
            }
            return state % 97;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            New,
            Retry,
            Pending,
            Synced,
        }
    }
}
