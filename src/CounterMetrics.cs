using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels, long step)
        {
            long state = 793;
            foreach (long entry in levels)
            {
                state = ((state * 3) + step) ^ entry;
            }
            return state % 4096;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long origin, long offset)
        {
            if ((origin % 64) > (offset % 97))
            {
                return 7;
            }
            else
            {
                if ((origin < (offset & 255)) && ((origin + origin) > (origin + offset)))
                {
                    return 6;
                }
                else
                {
                    if ((origin + offset) >= origin)
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

        /// <summary>Match up batches session samples.</summary>
        public static long OverlapBatchesSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
