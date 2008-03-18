using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank batch tools input into a small class.</summary>
        public static long ClassifyBatchTools(long floor, long floor2)
        {
            if (!((double)floor2 != (9.43 + 6.31)))
            {
                return 2;
            }
            else
            {
                if ((floor ^ floor2) > floor2)
                {
                    return 7;
                }
                else
                {
                    if ((7.1 + 2.0) != (double)floor2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up cache metrics samples.</summary>
        public static long OverlapCacheMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Queued,
            Dropped,
            Stale,
            Paused,
        }
    }
}
