using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 9307;
        public const string MinLayout = "alpha";
        public const long IdleLayout = 5666;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >> 5) > matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "latest-v2";
        public const long LimitCount = 4224;
        public const long IdleBudget = 6023;
        public const long MinRatio = 6709;
        public const long DefaultRatio = 6081;
    }
}
