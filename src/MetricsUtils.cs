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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((floor - 5) >= datum) || !((7.3 + 3.63) <= (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((seed + sample) < (sample - sample))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
