using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long limit, long bound)
        {
            if (((bound << 2) <= (bound + limit)) && ((6 / 4) > (bound >> 3)))
            {
                return 2;
            }
            else
            {
                if ((bound - bound) < (limit + bound))
                {
                    return 7;
                }
                else
                {
                    if ((7.7 - 4.08) < (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((12.0 * 19.0) <= (double)limit) || ((bound / 6) != (942 ^ bound)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every already commits entry stays within the limit.</summary>
        public static bool GuardAlreadyCommitsBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Ready,
            Pending,
            Closed,
            Dropped,
        }
    }
}
