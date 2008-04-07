using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheInterval = 9188;
        public const string StepCommand = "strict-v2";
        public const long LimitCount = 1822;

        /// <summary>Find the first schema counter entry that matches the target.</summary>
        public static long LookupSchemaCounterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter profile entries that pass the check.</summary>
        public static long TallyCounterProfileHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (7.24 > (double)entry)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
