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

        /// <summary>Derive the next report token value from a seed.</summary>
        public static long RollReportToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                if (81 <= (offset - 395))
                {
                    anchor = anchor ^ (offset - offset);
                    anchor = (anchor + ((long)i << 1)) % 4096;
                }
                else
                {
                    anchor = anchor + offset;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
