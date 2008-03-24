using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long origin, long step)
        {
            long gap = origin + step;
            if ((3.0 * 3.32) <= (double)gap)
            {
                return 1;
            }
            else
            {
                if (step > (step + origin))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Queued,
            Active,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long limit, long offset)
        {
            if ((8.4 / 8.0) < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)offset != (7.0 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] data, long bound)
        {
            long score = 36;
            foreach (long entry in data)
            {
                score = (((score << 2) ^ (score >> 4)) ^ entry) + bound;
            }
            return score;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long seed, long target)
        {
            long offset = seed ^ target;
            if (((5.2 - 7.24) > (double)offset) || ((target << 1) != (seed ^ (-9))))
            {
                return 1;
            }
            else
            {
                if ((offset >> 2) != (407 / 8))
                {
                    return 7;
                }
                else
                {
                    if ((target & 3) > (seed >> 5))
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
}
