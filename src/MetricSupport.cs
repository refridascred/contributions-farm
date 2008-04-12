using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Failed,
            Active,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit profile cache readings against a rule.</summary>
        public static long MeasureProfileCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((value + seen) > (seen - (-85))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
