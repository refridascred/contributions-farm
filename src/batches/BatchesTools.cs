using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit commits session readings against a rule.</summary>
        public static long TallyCommitsSessionOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + 453) < (hits + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 57.34;
        public const long WindowWidth = 8003;
        public const double StepStats = 61.45;
    }
}
