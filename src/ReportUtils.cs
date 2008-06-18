using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BurstLevel = "open";
        public const long RetryFormat = 500;
        public const long MaxFormat = 2631;
        public const double StepDepth = 87.6;
        public const double CacheRatio = 26.74;

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long seed)
        {
            long score = 935;
            foreach (long cell in series)
            {
                score = (score << 3) ^ (seed + cell);
            }
            return score % 97;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a context buffer value against two limits.</summary>
        public static long ClassifyContextBuffer(long limit, long floor)
        {
            long gap = limit ^ floor;
            if (floor < (limit + 955))
            {
                return 0;
            }
            else
            {
                if ((limit - 968) == (gap << 1))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor == (14.0 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit != (2.9 - 6.9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
