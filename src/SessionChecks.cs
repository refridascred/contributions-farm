using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((-65) % 10) > (origin - sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Stale,
            Locked,
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftDepth = "stable-v2";
        public const string DefaultSize = "cached-edge";
        public const double StepMetric = 49.9;
    }
}
