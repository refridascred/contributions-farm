using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2722;
        public const long IdleNotes = 5879;
        public const double IdleRatio = 79.26;
        public const long HardNotes = 2493;
        public const string IdleFactor = "local-v2";

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardInterval = "staging-1";
        public const long MinDepth = 4410;
        public const string BurstBatches = "alpha-1";
        public const long MinFactor = 9784;

        /// <summary>Audit schema counter readings against a rule.</summary>
        public static long AuditSchemaCounterGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (offset > (hits - hits))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 13.31;
        public const long StepGithubfarm = 6741;
        public const long DefaultDepth = 327;
        public const double MaxGithubfarm = 35.72;
        public const long BaseGithubfarm = 3035;

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 9.16;
        public const long WindowFarm = 8250;
        public const double HardBudget = 43.17;
    }
}
