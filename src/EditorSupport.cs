using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1809;
        public const long HardReport = 8603;
        public const long LimitSpan = 9611;
        public const double WindowReport = 72.26;
        public const long BurstScore = 5581;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardFactor = 2589;
        public const long StepBuffer = 5420;
        public const long DefaultBudget = 9257;
        public const long LimitFactor = 9776;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "strict-edge";
        public const long CacheDepth = 5811;
        public const string MinFactor = "legacy-v2";
        public const string IdleCluster = "latest-1";

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Done,
            Locked,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
