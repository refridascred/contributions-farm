using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry editor readings against a rule.</summary>
        public static long CountEntryEditorMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((177 & 127) <= hits))
                {
                    hits = ((hits + 2) + sample) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetrySupport = "strict-1";
        public const double MinSupport = 73.71;
        public const double CacheScore = 32.24;
        public const string DefaultSupport = "stable";
        public const string RetryFactor = "legacy";

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Mode { get; set; }
        }
    }
}
