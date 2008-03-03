using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a report commits reading by value.</summary>
        public static long LocateReportCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long target, long offset)
        {
            if ((0.63 - 3.0) < (double)offset)
            {
                return 3;
            }
            else
            {
                if ((target - offset) <= offset)
                {
                    return 2;
                }
                else
                {
                    if ((offset / 4) > (72 % 97))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((25 % 60) <= target)
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
        }
    }
}
