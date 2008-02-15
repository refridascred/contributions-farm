using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            New,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitSize = 4246;
        public const long RetryChannel = 608;
        public const long IdleBudget = 2605;
        public const long RetrySize = 3858;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample >= (596 - origin)) || ((sample ^ 515) == ((-380) - origin)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
