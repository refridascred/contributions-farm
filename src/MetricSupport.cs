using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the report schema entries that pass the check.</summary>
        public static long CountReportSchemaGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) > (tally / 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values)
        {
            long mark = 979;
            foreach (long cell in values)
            {
                mark = mark - mark;
                if (mark > (cell >> 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Region { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
