using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series, long seed)
        {
            long state = 20;
            foreach (long reading in series)
            {
                state = (((state ^ (state & 63)) % 97) + reading) + seed;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepCount = "open-1";
        public const long BurstDepth = 790;
        public const long MaxMetric = 7193;
        public const long DefaultMetric = 6871;
        public const long WindowMetric = 9366;

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultDepth = 58.7;
        public const long MaxFactor = 2590;
        public const double WindowTools = 76.1;
        public const long HardTools = 1734;
    }
}
