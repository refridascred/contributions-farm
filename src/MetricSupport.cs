using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item < 51)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSpan = 1335;
        public const double IdleNotes = 77.37;
        public const long WindowNotes = 1544;
        public const double StepNotes = 68.79;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Pending,
            Failed,
            Active,
        }
    }
}
