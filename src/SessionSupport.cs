using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine filter already values into a single score.</summary>
        public static long ScoreFilterAlready(long[] data)
        {
            long total = 26;
            foreach (long item in data)
            {
                total = (total ^ (2 * 5)) + item;
                total = total ^ (78 ^ 3);
            }
            return total % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryCount = 8663;
        public const string StepChannel = "legacy-1";
        public const double BaseLevel = 31.14;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Dropped,
            Stale,
            Failed,
            Ready,
        }
    }
}
