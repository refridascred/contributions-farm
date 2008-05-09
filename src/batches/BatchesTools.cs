using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long floor, long target)
        {
            long lane = floor + target;
            if ((0.6 * 14.0) <= (double)target)
            {
                return 6;
            }
            else
            {
                if (((target % 60) >= floor) || ((floor - 155) <= floor))
                {
                    return 2;
                }
                else
                {
                    if (target <= (lane % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
