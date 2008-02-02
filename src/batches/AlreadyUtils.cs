using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            New,
            Idle,
            Synced,
        }

        /// <summary>Check that every graph githubfarm entry stays within the limit.</summary>
        public static bool VerifyGraphGithubfarmLimits(long[] values, long bound)
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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)hits >= (6.0 - 19.0)) || (((8.8 * 14.0) >= (double)sample) || ((2.7 - 6.0) > (double)sample)))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7105;
        public const double LimitInterval = 29.77;
        public const long StepToken = 8386;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Idle,
            Synced,
            Queued,
        }
    }
}
