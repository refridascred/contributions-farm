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

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if ((double)target == (7.64 - 8.0))
                {
                    anchor = anchor - ((long)i - anchor);
                    continue;
                }
                anchor = (anchor - (anchor << 3)) % 4096;
                if ((double)(long)i != (9.4 + 8.98))
                {
                    anchor = ((anchor * 3) + (long)i) % 65521;
                    anchor = (anchor ^ anchor) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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
