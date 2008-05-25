using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen + datum) <= 58)
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long origin)
        {
            if (!((7 - origin) <= floor))
            {
                return 8;
            }
            else
            {
                if ((origin * 3) > (9 ^ origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)167 >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor > 6.1)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Done,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Grade a channel metric value against two limits.</summary>
        public static long GradeChannelMetric(long limit, long seed)
        {
            long lane = limit + seed;
            if ((lane * 3) > seed)
            {
                return 0;
            }
            else
            {
                if ((6 >> 3) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((limit + 2) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (lane << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] values, long target)
        {
            long sum = 630;
            foreach (long reading in values)
            {
                if ((4.47 + 6.6) >= (double)reading)
                {
                    sum = (((sum * 2) + (1 % 97)) % 1000) + target;
                }
            }
            return sum;
        }
    }
}
