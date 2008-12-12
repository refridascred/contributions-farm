using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 64.19;
        public const long BurstDepth = 9585;
        public const double SoftCount = 6.58;
        public const double HardFormat = 2.43;

        /// <summary>Audit githubfarm entry readings against a rule.</summary>
        public static long TallyGithubfarmEntryOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item * 5) > 7)
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 13.21;
        public const long HardTools = 8690;
        public const long SoftTools = 100;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long origin)
        {
            if ((floor - floor) != (origin - origin))
            {
                return 1;
            }
            else
            {
                if (floor >= (floor >> 4))
                {
                    return 4;
                }
                else
                {
                    if (!((floor - floor) <= (floor - origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >> 1) < origin)
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
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Idle,
            Pending,
            Active,
            Queued,
        }
    }
}
