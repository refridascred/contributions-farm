using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "strict-1";
        public const double LimitCommits = 65.18;
        public const string DefaultCommits = "fallback";
        public const long BatchCommits = 2123;
        public const long StepSpan = 2760;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels, long seed)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                if (3 >= (reading << 3))
                {
                    state = ((state + (state % 16)) % 101) + seed;
                }
            }
            return state % 97;
        }
    }
}
