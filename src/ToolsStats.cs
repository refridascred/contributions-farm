using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long step, long limit)
        {
            long lane = step + limit;
            if ((16 + 33) < (step & 1))
            {
                return 0;
            }
            else
            {
                if ((lane - limit) < (limit + 195))
                {
                    return 2;
                }
                else
                {
                    if ((lane / 5) < 77)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long step, long origin)
        {
            if ((double)origin > (double)step)
            {
                return 0;
            }
            else
            {
                if ((662 + origin) <= step)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((target ^ seen) <= (seen + reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
