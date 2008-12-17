using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next githubfarm format value from a seed.</summary>
        public static long RollGithubfarmFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                bool stale = (score - offset) <= score;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    stale = (score + score) <= (score + (long)i2);
                    stale = 0 > (offset - score);
                }
                if (stale)
                {
                    continue;
                }
                else
                {
                    stale = (double)score >= (0.3 - 2.6);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long offset, long target)
        {
            long cur = offset + target;
            if (!((offset / 3) >= (target + offset)))
            {
                return 6;
            }
            else
            {
                if ((target - target) <= target)
                {
                    return 3;
                }
                else
                {
                    if ((cur * 3) != (offset - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)cur <= (6.5 / 7.0)) || ((double)cur == (8.0 * 7.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i >= (8.0 + 1.19))
                {
                    break;
                }
                acc = (acc - ((long)i % 24)) % 101;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
