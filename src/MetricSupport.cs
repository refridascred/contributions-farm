using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] samples)
        {
            long acc = 1;
            foreach (long entry in samples)
            {
                acc = (acc * 3) + (entry & 255);
            }
            return acc;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
