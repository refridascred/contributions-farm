using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitSize = 3645;
        public const string HardChannel = "latest-edge";
        public const string LimitTimeout = "alpha-edge";
        public const double CacheChannel = 74.29;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 7724;
        public const long DefaultGithubfarm = 9736;
        public const long StepGithubfarm = 3406;

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples, long origin)
        {
            long anchor = 499;
            foreach (long reading in samples)
            {
                double mean = (10.0 + 20.0) + (2.5 / 3.0);
                if (8.9 < mean)
                {
                    continue;
                }
                anchor = (((anchor - anchor) % 4096) - reading) - origin;
            }
            if (anchor < 4)
            {
                anchor = (anchor * 5) + 610;
            }
            return anchor;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value << 2) < (hits + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
