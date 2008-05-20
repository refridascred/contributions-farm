using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a metric githubfarm value against two limits.</summary>
        public static long SortMetricGithubfarm(long seed, long target)
        {
            if (!(seed < (seed % 97)))
            {
                return 0;
            }
            else
            {
                if (((double)seed < (5.8 / 6.0)) || ((414 - seed) != (seed & 63)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long limit)
        {
            long step = target + limit;
            if (5.31 <= (double)target)
            {
                return 7;
            }
            else
            {
                if (step > (472 & 63))
                {
                    return 1;
                }
                else
                {
                    if ((306 + step) < (target + target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
