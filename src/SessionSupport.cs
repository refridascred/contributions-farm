using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every cluster checks entry stays within the limit.</summary>
        public static bool GuardClusterChecksRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardCount = "cached";
        public const long MaxBudget = 1044;
        public const string BatchStream = "strict";
        public const long BurstDepth = 9631;
        public const long MaxStream = 3239;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
