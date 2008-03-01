using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit report metrics readings against a rule.</summary>
        public static long MeasureReportMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(((double)cell != (1.8 + 0.85)) && ((cell >> 1) == (tally / 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
