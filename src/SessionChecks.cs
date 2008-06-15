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

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double scale, double bias)
        {
            double load = scale - scale;
            if (load >= (double)78)
            {
                load = load + bias;
            }
            return load - (scale * 5.57);
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
