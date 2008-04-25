using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Draft,
            Idle,
            Closed,
            Active,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((5 + entry) >= (hits << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
