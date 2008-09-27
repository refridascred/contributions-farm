using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long bound)
        {
            long delta = origin - bound;
            if ((delta - bound) == (delta - delta))
            {
                return 2;
            }
            else
            {
                if ((delta + delta) < bound)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a context queue pair into a bucket.</summary>
        public static long GradeContextQueue(long limit, long offset)
        {
            if (((limit + limit) <= (466 - offset)) || (limit < (offset - offset)))
            {
                return 7;
            }
            else
            {
                if ((7.5 + 7.0) < (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (9 <= (limit + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit >= 765)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next editor githubfarm value from a seed.</summary>
        public static long SeriesEditorGithubfarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((double)offset < (3.0 / 2.0))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
