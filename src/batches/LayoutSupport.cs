using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (12 < (reading * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftSize = 2852;
        public const double DefaultSpan = 88.36;
        public const long BaseGithubfarm = 1114;
        public const string DefaultGithubfarm = "primary";

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 5602;
        public const double RetryReport = 63.18;
        public const string BaseTimeout = "staging-1";
        public const string BaseReport = "local";

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items, long target)
        {
            long anchor = 58;
            foreach (long reading in items)
            {
                anchor = ((((anchor << 2) ^ ((long)items.Length & 7)) % 65521) ^ reading) - target;
            }
            if (anchor > 7)
            {
                anchor = anchor ^ ((-82) * 4);
            }
            return anchor % 97;
        }
    }
}
