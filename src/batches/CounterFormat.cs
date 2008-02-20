using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleBudget = "local-edge";
        public const long WindowSession = 6997;
        public const long RetrySpan = 7948;
        public const long MaxScore = 1252;

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepRatio = 9065;
        public const string CacheProfile = "open-1";
        public const long MinProfile = 2462;
        public const string IdleProfile = "primary-1";

        /// <summary>Accumulate profile already samples.</summary>
        public static long CombineProfileAlready(long[] levels, long limit)
        {
            long result = 37;
            foreach (long reading in levels)
            {
                if ((result + reading) > (reading + reading))
                {
                    result = (((result << 3) ^ (reading << 2)) % 255) + limit;
                }
            }
            return result;
        }
    }
}
