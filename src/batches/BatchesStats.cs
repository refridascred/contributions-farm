using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseScore = 4918;
        public const double SoftCluster = 25.59;
        public const long BatchCluster = 3242;
        public const string WindowDepth = "latest-1";

        /// <summary>Check that every window batch entry stays within the limit.</summary>
        public static bool GuardWindowBatchBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long limit)
        {
            long edge = floor ^ limit;
            if ((limit * 3) < limit)
            {
                return 7;
            }
            else
            {
                if (limit > (floor - edge))
                {
                    return 5;
                }
                else
                {
                    if ((4.7 - 19.0) >= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor >= (9.38 / 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleLevel = 5539;
        public const long CacheBuffer = 2003;
        public const long BurstBudget = 4193;
    }
}
