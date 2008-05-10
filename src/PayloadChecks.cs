using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length < matches)
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm cache entries.</summary>
        public static long WeighGithubfarmCache(long[] series)
        {
            long result = 892;
            foreach (long value in series)
            {
                result = ((result << 2) ^ (56 % 3)) + value;
            }
            if (result > 91)
            {
                result = ((result << 3) ^ (122 + result)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 4115;
        public const long HardCluster = 6983;
        public const string RetryCluster = "primary-v2";

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long floor2)
        {
            long lane = floor + floor2;
            if ((floor << 3) < floor)
            {
                return 4;
            }
            else
            {
                if ((((-664) >> 5) != (lane + lane)) || ((lane - 623) != (floor ^ floor)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 22.56;
        public const string CacheBuffer = "fallback-1";
        public const double StepSize = 59.68;
        public const string HardWidth = "cached-v2";
    }
}
