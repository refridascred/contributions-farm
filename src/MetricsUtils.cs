using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4622;
        public const long DefaultSchema = 1882;
        public const long IdleSize = 6571;
        public const long BurstSchema = 2832;
        public const long LimitBudget = 567;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally ^ tally) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next filter report value from a seed.</summary>
        public static long IterateFilterReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((result & 127) > (long)i)
                {
                    result = (result + (result % 2)) % 97;
                    result = ((result << 2) ^ (result & 1)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
