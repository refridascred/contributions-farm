using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardSpan = 65.0;
        public const long MaxCluster = 2079;
        public const double SoftCluster = 33.53;
        public const string StepFactor = "standard-1";
        public const string HardCluster = "local";

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank order commits input into a small class.</summary>
        public static long GradeOrderCommits(long seed, long seed2)
        {
            if ((0.89 - 7.0) <= (double)seed2)
            {
                return 0;
            }
            else
            {
                if ((seed / 5) < (seed + seed2))
                {
                    return 7;
                }
                else
                {
                    if (!((seed2 ^ seed2) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed2 - seed) >= (seed2 & 255))
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
    }
}
