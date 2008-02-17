using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstBudget = 4256;
        public const string RetrySession = "primary-edge";
        public const long CacheSession = 6938;
        public const long WindowSession = 7188;
        public const long CacheInterval = 9835;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading << 3) >= 47)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
