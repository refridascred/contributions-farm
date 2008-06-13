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

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long step)
        {
            long delta = bound + step;
            if ((4 & 7) > bound)
            {
                return 2;
            }
            else
            {
                if ((bound - step) > (step << 1))
                {
                    return 4;
                }
                else
                {
                    if ((bound * 5) < delta)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
