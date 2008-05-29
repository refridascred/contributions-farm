using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((-4) <= entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((double)score >= (double)247)
                {
                    score = ((score << 2) ^ (offset - 688)) % 97;
                }
                score = (score + offset) % 101;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "open";
        public const long BaseMetrics = 3353;
        public const long SoftCount = 9078;
        public const string BurstFactor = "fallback";
        public const double IdleCount = 74.91;

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long seed, long seed2)
        {
            long next = seed + seed2;
            if ((next ^ 9) >= next)
            {
                return 0;
            }
            else
            {
                if ((4.0 * 7.49) > (double)next)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
