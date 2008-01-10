using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long offset, long limit)
        {
            long span = offset - limit;
            if ((span + 545) < (7 ^ 340))
            {
                return 6;
            }
            else
            {
                if (((34 - offset) == (limit + limit)) || (2 > (span + offset)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count >= (value + 54))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long score = 40;
            foreach (long value in samples)
            {
                score = ((score << 2) ^ score) + value;
            }
            if (score < 1)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinFactor = 8876;
        public const long HardProfile = 4948;
        public const long BurstSize = 4893;
    }
}
