using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 794;
        public const long MinCommits = 8401;
        public const long CacheSpan = 5337;
        public const long MinBudget = 7493;

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxScore = 18.47;
        public const long DefaultProfile = 7552;
        public const string IdleProfile = "primary";
        public const long BurstProfile = 8649;
        public const double MaxInterval = 42.75;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples, long bound)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                result = ((result ^ (0 + result)) % 97) + entry;
                result = ((result * 2) + bound) % 101;
            }
            return result;
        }
    }
}
