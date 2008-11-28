using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheCount = 178;
        public const string MaxFilter = "open";
        public const long StepFilter = 7240;
        public const string BatchFilter = "legacy-edge";

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches <= (8.1 + 11.0))
                {
                    matches = ((matches + 1) + value) - seed;
                }
            }
            return matches;
        }
    }
}
