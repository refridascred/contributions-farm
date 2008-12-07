using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long limit)
        {
            long offset = bound - limit;
            if ((double)limit <= (3.53 * 17.0))
            {
                return 4;
            }
            else
            {
                if ((bound * 3) >= (offset << 2))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Queued,
            Active,
            Paused,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 5262;
        public const string BurstCommand = "alpha-1";
        public const long MaxCommand = 635;
    }
}
