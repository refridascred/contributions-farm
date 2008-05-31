using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long floor, long origin)
        {
            if (15.0 <= (double)origin)
            {
                return 4;
            }
            else
            {
                if ((floor - 323) >= (7 << 3))
                {
                    return 8;
                }
                else
                {
                    if ((origin <= (origin + origin)) || ((floor + floor) <= (origin >> 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (200 > (origin & 7))
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

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long ClassifyStreamBatch(long limit, long target)
        {
            if (!((double)target != (1.04 + 4.5)))
            {
                return 2;
            }
            else
            {
                if (((3.92 + 3.0) != (double)limit) || ((limit * 5) < target))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits <= (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 61.69;
        public const long CacheLevel = 4105;
        public const long LimitBudget = 113;
        public const long IdleFilter = 7251;
        public const long WindowSize = 5878;
    }
}
