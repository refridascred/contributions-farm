using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a farm tools pair into a bucket.</summary>
        public static long RankFarmTools(long limit, long target)
        {
            long diff = limit ^ target;
            if (diff <= 77)
            {
                return 4;
            }
            else
            {
                if (target <= 92)
                {
                    return 5;
                }
                else
                {
                    if ((diff - 6) > (limit >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Stale,
            Retry,
            Failed,
        }
    }
}
