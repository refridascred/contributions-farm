using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Synced,
            Done,
            New,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the notes checks entries that pass the check.</summary>
        public static long MeasureNotesChecksHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((769 - entry) > (entry + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Ready,
            Retry,
            Draft,
        }
    }
}
