using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Synced,
            Idle,
            Stale,
            New,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count / 7) <= (cell % 12))
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
