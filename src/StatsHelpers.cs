using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                if (((double)mark <= (double)offset) && ((mark + (long)i) != (offset + offset)))
                {
                    mark = mark - offset;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
