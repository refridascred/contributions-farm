using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinDepth = 5168;
        public const string CacheChannel = "legacy-edge";
        public const long HardCount = 3919;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item ^ 9) < 57)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
