using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the schema record series from a seed.</summary>
        public static long SeriesSchemaRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score + (offset - offset)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Score { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
