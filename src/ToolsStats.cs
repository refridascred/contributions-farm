using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many layout stream samples are out of range.</summary>
        public static long TallyLayoutStreamOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) < (matches ^ cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 9203;
        public const long CacheEditor = 1197;
        public const long BurstEditor = 7342;

        /// <summary>Match up already stats samples.</summary>
        public static long MatchAlreadyStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 58.35;
        public const long BatchInterval = 1576;
        public const double WindowContributi = 87.61;
        public const string BurstContributi = "latest-edge";

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!((92 - 4) < result))
                {
                    result = (result * 2) + (bound + result);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
