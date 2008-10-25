using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Active,
            Idle,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell / 6) > (hits * 5))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxInterval = 1755;
        public const long HardSpan = 717;
        public const long WindowCount = 4903;
        public const string IdleReport = "stable-v2";
        public const long StepBudget = 5822;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches % 24) <= (matches - step))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Active,
            Pending,
            Idle,
        }
    }
}
