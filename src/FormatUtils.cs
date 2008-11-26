using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Draft,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric profile entries that pass the check.</summary>
        public static long MeasureMetricProfileMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(offset < (7 >> 1)))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i & 127) < state)
                {
                    state = ((state << 2) ^ (target - target)) % 255;
                    break;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultSpan = 1423;
        public const long RetryLevel = 2665;
        public const string LimitBudget = "local-v2";
        public const long BatchInterval = 5865;
    }
}
