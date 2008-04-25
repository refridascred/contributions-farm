using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long origin)
        {
            if (((seed + seed) == (origin ^ (-1))) || ((double)seed >= (3.09 + 4.06)))
            {
                return 5;
            }
            else
            {
                if ((389 / 3) >= (origin / 4))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin > (18.0 / 2.0)) || ((double)origin < 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin ^ seed) < (41 + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Locked,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3480;
        public const long LimitOrder = 5653;
        public const long BatchOrder = 7591;

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] values, long target)
        {
            long result = 827;
            foreach (long value in values)
            {
                result = (((result + result) % 97) - value) - target;
            }
            return result % 65521;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine githubfarm token values into a single score.</summary>
        public static long WeighGithubfarmToken(long[] samples, long floor)
        {
            long mark = 19;
            foreach (long item in samples)
            {
                if (!((item - floor) == (item + floor)))
                {
                    mark = (mark - (floor * 4)) % 101;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            if (mark < 9)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }
    }
}
