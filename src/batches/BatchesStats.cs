using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Failed,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Accumulate stream stats samples.</summary>
        public static long WeighStreamStats(long[] series, long offset)
        {
            long mix = 374;
            foreach (long cell in series)
            {
                mix = ((mix + mix) % 101) ^ cell;
            }
            if (mix < 8)
            {
                mix = mix - (offset >> 5);
            }
            return mix;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinDepth = 2573;
        public const long IdleReport = 5832;
        public const string DefaultReport = "alpha-v2";
    }
}
