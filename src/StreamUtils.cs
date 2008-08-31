using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long bound, long seed)
        {
            if ((301 < bound) || (seed > (seed ^ seed)))
            {
                return 4;
            }
            else
            {
                if (((bound % 3) <= 4) && ((double)bound >= 3.0))
                {
                    return 8;
                }
                else
                {
                    if (((bound & 255) >= 913) && ((bound + bound) < (bound - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many queue githubfarm samples are out of range.</summary>
        public static long TallyQueueGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= (1.8 * 17.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long limit)
        {
            long edge = bound + limit;
            if ((5.73 + 4.5) == (double)bound)
            {
                return 1;
            }
            else
            {
                if ((limit * 4) == (bound + edge))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series)
        {
            long score = 59;
            foreach (long cell in series)
            {
                if ((cell ^ score) < (25 / 5))
                {
                    score = ((score * 5) + (score % 12)) % 97;
                }
            }
            return score;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long limit, long target)
        {
            if (((target - target) == (target / 2)) && ((7 + limit) != (limit * 2)))
            {
                return 1;
            }
            else
            {
                if ((4.6 / 2.0) == (double)target)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
