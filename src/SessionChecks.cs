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

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Dropped,
            Failed,
        }

        /// <summary>Locate a account counter reading by value.</summary>
        public static long SeekAccountCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
