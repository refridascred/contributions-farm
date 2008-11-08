using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "primary";
        public const string CacheBudget = "open-1";
        public const long MinSpan = 8854;
        public const long WindowInterval = 1654;

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "staging";
        public const long WindowStats = 6953;
        public const long MaxStats = 380;
        public const long WindowSpan = 8444;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((-8) <= (hits ^ 7))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
