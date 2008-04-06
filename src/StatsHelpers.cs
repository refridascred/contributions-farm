using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Count { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Retry,
            Failed,
            New,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((hits & 1) == (hits & 63)) || ((9 - hits) <= (hits + hits))) && ((hits - origin) > (hits & 3)))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Pending,
            Dropped,
            Closed,
            Synced,
        }
    }
}
