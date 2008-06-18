using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series, long origin)
        {
            long state = -797;
            foreach (long reading in series)
            {
                if ((double)origin == (double)13)
                {
                    state = (((state << 3) ^ 6) % 1000) ^ reading;
                }
                else
                {
                    state = state + (602 * 4);
                }
            }
            return state;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (2.0 > (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            New,
            Done,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 30.72;
        public const string BurstWidth = "staging-v2";
        public const long CacheRecord = 7294;
    }
}
