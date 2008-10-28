using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardWidth = "open";
        public const string IdleChecks = "standard";
        public const string BaseChecks = "stable-edge";
        public const long MaxChecks = 7039;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
