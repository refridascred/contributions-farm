using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MinSize = "fallback-v2";
        public const string StepDepth = "legacy-1";
        public const string IdleBatch = "stable";

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((-18) < (hits + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report tools samples are out of range.</summary>
        public static long TallyReportToolsGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((7 <= value) || ((5 & 7) <= (count ^ count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Paused,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 79;
        public const long RetryProfile = 7807;
        public const long WindowSize = 4717;
        public const long WindowProfile = 5577;
        public const string BatchFactor = "standard";
    }
}
