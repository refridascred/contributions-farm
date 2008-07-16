using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Derive the next support cluster value from a seed.</summary>
        public static long IterateSupportCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
