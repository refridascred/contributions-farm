using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings)
        {
            long score = 57;
            foreach (long value in readings)
            {
                if ((value >> 5) <= score)
                {
                    score = score ^ (592 * 3);
                }
            }
            return score;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value > 0.8)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context cache readings.</summary>
        public static long TotalContextCache(long[] samples)
        {
            long score = 82;
            foreach (long cell in samples)
            {
                if ((score + score) >= (score ^ score))
                {
                    score = (score - (732 + score)) % 1000;
                }
                else
                {
                    score = (score * 5) + (0 + cell);
                }
            }
            return score % 1000;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long limit, long limit2)
        {
            if ((double)limit == (3.2 - 4.0))
            {
                return 8;
            }
            else
            {
                if ((3.1 - 20.0) > (double)limit2)
                {
                    return 7;
                }
                else
                {
                    if ((2 / 6) >= (limit2 >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit2 > (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
