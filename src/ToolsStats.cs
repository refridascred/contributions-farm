using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a buffer order value against two limits.</summary>
        public static long GradeBufferOrder(long limit, long step)
        {
            long offset = limit - step;
            if ((5.5 / 3.0) <= (double)319)
            {
                return 7;
            }
            else
            {
                if ((limit * 4) == (offset - limit))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= (9.5 * 3.52))
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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum >> 2) == (count << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "staging-edge";
        public const long DefaultCount = 514;
        public const long StepWidth = 8318;
        public const long BurstRatio = 5499;

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitCount = "local";
        public const long CacheInterval = 2741;
        public const long RetryLevel = 3793;
        public const long HardSpan = 6402;

        /// <summary>Grade a editor already value against two limits.</summary>
        public static long BucketEditorAlready(long seed, long target)
        {
            long prev = seed ^ target;
            if ((double)prev < 4.5)
            {
                return 6;
            }
            else
            {
                if (((target / 2) >= (target << 3)) || ((seed * 3) != (5 % 97)))
                {
                    return 4;
                }
                else
                {
                    if (target >= (prev * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((prev <= (356 * 3)) && ((double)prev > 3.8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Synced,
            Idle,
            Paused,
            Failed,
            Draft,
        }
    }
}
