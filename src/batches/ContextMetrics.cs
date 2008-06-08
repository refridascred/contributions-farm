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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((seed + seed) > (sample * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultDepth = 58.7;
        public const long MaxFactor = 2590;
        public const double WindowTools = 76.1;
        public const long HardTools = 1734;
    }
}
