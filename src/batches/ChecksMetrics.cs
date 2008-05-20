using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a route cluster sample.</summary>
        public static long FindRouteClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Paused,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long limit, long seed)
        {
            if (((seed - seed) <= limit) && (seed > (limit / 3)))
            {
                return 6;
            }
            else
            {
                if (((seed - limit) <= limit) && ((double)8 < (double)limit))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
