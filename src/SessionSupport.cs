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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((7 << 2) < cell)
                {
                    matches = (matches + 1) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
