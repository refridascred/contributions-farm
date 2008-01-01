using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long MeasureCommandFarmOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((4.13 / 5.0) >= (double)cell) || ((double)target >= (0.09 / 2.0)))
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

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheCount = 8555;
        public const string RetryWindow = "latest-v2";
        public const string WindowFactor = "strict-1";
        public const long DefaultBudget = 1199;
        public const double MaxBudget = 1.12;
    }
}
