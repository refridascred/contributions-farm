using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((floor ^ cell) != (2 & 15)) || ((3.5 + 13.0) == (double)floor))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 2644;
        public const double BurstLevel = 89.13;
        public const double SoftInterval = 27.62;

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleSize = 93.92;
        public const double MinWidth = 63.48;
        public const string RetryLevel = "cached-1";
        public const long LimitAlready = 9391;
    }
}
