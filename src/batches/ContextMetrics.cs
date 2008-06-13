using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue record values into a single score.</summary>
        public static long ScoreQueueRecord(long[] readings, long bound)
        {
            long score = 9;
            foreach (long cell in readings)
            {
                if (!((bound >> 1) >= (cell >> 2)))
                {
                    score = (score ^ (bound << 3)) % 255;
                }
            }
            if (score > (-48))
            {
                score = (score + (bound % 5)) % 101;
            }
            return score;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((cell + hits) <= cell) || ((double)cell > 3.44)) || (cell > (cell + cell)))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long limit, long bound)
        {
            long span = limit - bound;
            if ((span >> 4) > bound)
            {
                return 7;
            }
            else
            {
                if ((span < (bound + (-33))) || ((limit % 10) < (49 << 3)))
                {
                    return 8;
                }
                else
                {
                    if ((limit < 4) && ((double)span == (2.0 + 3.8)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
