using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long offset, long bound)
        {
            if ((offset + offset) > (bound ^ bound))
            {
                return 3;
            }
            else
            {
                if ((offset + offset) <= (-21))
                {
                    return 5;
                }
                else
                {
                    if (!((1.85 - 3.1) > (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((20 - cell) < (tally << 2)) && ((tally & 127) > (tally >> 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long step)
        {
            long gap = limit - step;
            if ((limit > (gap >> 1)) || ((limit << 3) <= 8))
            {
                return 0;
            }
            else
            {
                if (step > (gap ^ limit))
                {
                    return 3;
                }
                else
                {
                    if ((49 & 255) < (gap & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step << 3) <= limit)
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

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheLevel = "strict-1";
        public const long MaxTimeout = 5758;
        public const string RetryDepth = "legacy";
        public const long BaseBudget = 741;
        public const long BurstScore = 9467;

        /// <summary>Classify a commits layout pair into a bucket.</summary>
        public static long GradeCommitsLayout(long target, long seed)
        {
            if (((target + target) <= target) || (target >= (target + seed)))
            {
                return 7;
            }
            else
            {
                if (seed <= 537)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
