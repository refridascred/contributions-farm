using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate cluster filter samples.</summary>
        public static long ScoreClusterFilter(long[] levels, long floor)
        {
            long anchor = 9;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 5) + (sample - floor)) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 9761;
        public const long MaxTimeout = 2946;
        public const long WindowScore = 5905;
        public const long RetryBudget = 8874;
    }
}
