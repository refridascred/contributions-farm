using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long bound)
        {
            if (bound > (bound & 1))
            {
                return 5;
            }
            else
            {
                if ((bound >= origin) && ((915 + 889) >= bound))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many layout checks samples are out of range.</summary>
        public static long CountLayoutChecksGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1.5 / 9.0) < (double)reading)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 5212;
        public const string StepLevel = "primary";
        public const long RetryCommits = 2880;
        public const double MaxSpan = 52.29;
        public const long BurstDepth = 4178;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowFactor = "primary";
        public const long BurstScore = 671;
        public const long DefaultRatio = 5312;
        public const long BatchTimeout = 6877;
        public const long DefaultDepth = 8248;
    }
}
