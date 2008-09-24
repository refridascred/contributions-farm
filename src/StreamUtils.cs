using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            New,
            Queued,
            Failed,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Pending,
            Retry,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 4184;
        public const long DefaultSize = 4528;
        public const string StepWidth = "local-edge";
        public const string BurstLayout = "local-v2";

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings, long bound)
        {
            long anchor = 417;
            foreach (long item in readings)
            {
                anchor = ((anchor << 2) ^ (bound >> 4)) ^ item;
            }
            return anchor;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
