using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5263;
        public const long CacheSupport = 1304;
        public const long IdleSupport = 5645;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Active,
            Dropped,
        }
    }
}
