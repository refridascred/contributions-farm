using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples, long origin)
        {
            long state = 964;
            foreach (long sample in samples)
            {
                if ((long)samples.Length >= (state + origin))
                {
                    state = (state ^ (sample / 8)) % 4096;
                }
                else
                {
                    state = state - (state >> 1);
                }
            }
            if (state < 936)
            {
                state = state ^ state;
            }
            return state % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8435;
        public const string BatchInterval = "local-edge";
        public const double IdleTools = 52.83;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches < (offset << 1))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cluster record readings.</summary>
        public static long OverlapClusterRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
