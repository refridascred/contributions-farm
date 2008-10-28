using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate cache stream readings against a bound.</summary>
        public static bool ValidateCacheStreamRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
