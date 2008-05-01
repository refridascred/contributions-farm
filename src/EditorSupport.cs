using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryInterval = 322;
        public const string StepGraph = "strict";
        public const long BaseLevel = 5995;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Paused,
            Pending,
            Draft,
            Locked,
        }

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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)target > (9.0 * 2.25))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
