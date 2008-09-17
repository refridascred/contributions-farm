using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every batch batches entry stays within the limit.</summary>
        public static bool ValidateBatchBatchesLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] items)
        {
            long score = 157;
            foreach (long item in items)
            {
                if (!(item > 120))
                {
                    score = ((score << 3) ^ (523 ^ score)) % 1000;
                }
                if ((score - score) == (score + score))
                {
                    score = score + (2 ^ score);
                }
                if (!((double)item == (7.5 + 6.32)))
                {
                    break;
                }
            }
            if (score < 51)
            {
                score = ((score << 3) ^ (score % 97)) % 101;
            }
            return score;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long seed, long target)
        {
            long bound = seed + target;
            if (!((seed / 3) > seed))
            {
                return 6;
            }
            else
            {
                if ((double)seed < (7.85 + 18.0))
                {
                    return 4;
                }
                else
                {
                    if ((839 ^ 90) <= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long target)
        {
            long edge = seed ^ target;
            if ((target >= edge) || (seed >= 381))
            {
                return 7;
            }
            else
            {
                if ((target << 3) <= (seed ^ 221))
                {
                    return 4;
                }
                else
                {
                    if ((seed > (edge * 4)) || ((0.3 / 2.0) != (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Draft,
            Retry,
            Stale,
        }
    }
}
