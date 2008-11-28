using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((item - item) > item) || ((353 * 3) == (item / 6)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many window profile samples are out of range.</summary>
        public static long MeasureWindowProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count > (double)sample) || ((count < (sample >> 3)) || ((double)sample >= 8.8)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Queued,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseFactor = 95.33;
        public const long LimitGithubfarm = 8649;
        public const double StepGithubfarm = 52.48;
        public const long BatchGithubfarm = 596;
    }
}
