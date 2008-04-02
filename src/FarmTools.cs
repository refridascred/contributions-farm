using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many contributi farm samples are out of range.</summary>
        public static long AuditContributiFarmHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen < (value + floor))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Done,
            Idle,
            Pending,
        }
    }
}
