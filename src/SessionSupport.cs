using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((5.5 * 5.2) == (double)datum))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= 7.2)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseRatio = "open";
        public const long MinTimeout = 7617;
        public const long SoftSchema = 1642;
        public const long MaxDepth = 9040;
    }
}
