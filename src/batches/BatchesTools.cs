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

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long bound, long offset)
        {
            long next = bound ^ offset;
            if ((95 - next) != (bound << 2))
            {
                return 2;
            }
            else
            {
                if (((bound ^ bound) <= 599) || ((bound - offset) >= (next + bound)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
