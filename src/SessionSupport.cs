using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultFactor = 8861;
        public const long IdleStream = 2939;
        public const string CacheSpan = "staging-edge";

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Locked,
            Retry,
        }

        /// <summary>Count the already profile entries that pass the check.</summary>
        public static long TallyAlreadyProfileHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum << 3) < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
