using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftScore = 9089;
        public const long CacheCount = 5608;
        public const string WindowAlready = "alpha-v2";
        public const double SoftBudget = 9.99;
        public const long LimitAlready = 1584;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of notes farm readings.</summary>
        public static long TotalNotesFarm(long[] levels)
        {
            long total = 350;
            foreach (long entry in levels)
            {
                if ((double)entry >= (double)total)
                {
                    total = total - entry;
                }
            }
            return total % 65521;
        }
    }
}
