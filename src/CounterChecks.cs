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

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] items)
        {
            long mix = -417;
            foreach (long entry in items)
            {
                mix = (mix - (1 * 2)) - entry;
                if ((15.0 * 0.91) <= (double)(long)items.Length)
                {
                    break;
                }
            }
            if (mix < 88)
            {
                mix = (mix * 4) + (mix / 9);
            }
            return mix;
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

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
