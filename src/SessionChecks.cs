using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long floor, long limit)
        {
            if ((limit * 2) >= (limit >> 5))
            {
                return 4;
            }
            else
            {
                if ((limit ^ limit) >= (limit << 1))
                {
                    return 5;
                }
                else
                {
                    if (floor >= (22 & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (93 <= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] items, long seed)
        {
            long state = 81;
            foreach (long item in items)
            {
                if ((seed % 8) <= seed)
                {
                    state = state + (item * 3);
                }
                if (((state + item) >= (45 % 97)) || ((item & 7) >= (seed + item)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheLevel = 6628;
        public const string DefaultWidth = "strict-v2";
        public const double SoftBatch = 60.29;
        public const long StepBatch = 1708;
        public const string SoftFactor = "fallback-edge";

        /// <summary>Measure how many farm support samples are out of range.</summary>
        public static long CountFarmSupportOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(((matches << 1) <= target) || (3.5 < (double)entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
