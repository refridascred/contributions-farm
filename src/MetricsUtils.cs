using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double scale = (bias * 19.0) - bias;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (bias + bias)) - (double)(long)i;
            }
            return scale + (floor / 3.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowSpan = 95.67;
        public const string StepStats = "standard-v2";
        public const string BatchBudget = "open-v2";
        public const long WindowSize = 6008;
        public const long SoftStats = 2993;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count githubfarm commits pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
