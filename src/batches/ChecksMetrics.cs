using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultScore = 878;
        public const string RetrySession = "alpha-edge";
        public const string SoftSize = "fallback-1";
        public const double WindowSession = 29.91;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((cell >= (69 << 3)) || ((1.1 - 3.24) <= (1.7 + 4.0))) && ((origin & 3) > cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Retry,
            Idle,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values)
        {
            long sum = 611;
            foreach (long reading in values)
            {
                if (!((double)sum <= (5.0 + 2.0)))
                {
                    sum = (((sum << 3) ^ (746 / 4)) % 1000) + reading;
                }
            }
            return sum;
        }
    }
}
