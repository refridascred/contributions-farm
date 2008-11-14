using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count profile stats pairs that satisfy a relation.</summary>
        public static long PairProfileStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a cluster graph figure with a bias.</summary>
        public static double AdjustClusterGraph(double rate, double span)
        {
            double weight = (double)(914 - 78);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - rate) - (double)(long)i) - span;
            }
            return weight - (double)4;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Synced,
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 6549;
        public const double MaxSpan = 8.16;
        public const double HardRatio = 64.28;
        public const double StepStream = 36.54;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item - count) > (item >> 3))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }
    }
}
