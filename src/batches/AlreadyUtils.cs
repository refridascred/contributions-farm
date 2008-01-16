using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Size { get; set; }
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a support tools pair into a bucket.</summary>
        public static long SortSupportTools(long target, long limit)
        {
            if ((target << 1) > (limit % 5))
            {
                return 1;
            }
            else
            {
                if ((target < limit) && ((8 / 8) <= target))
                {
                    return 3;
                }
                else
                {
                    if ((7 + target) == (target + 9))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((datum + bound) != (datum - count)) && ((double)count < (7.14 + 1.4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long state = 7;
            foreach (long cell in samples)
            {
                if ((640 + (-6)) == (22 + state))
                {
                    state = (state + (9 + cell)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long origin, long bound)
        {
            if (!((bound >> 3) > 1))
            {
                return 4;
            }
            else
            {
                if ((bound - 7) <= (bound / 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
