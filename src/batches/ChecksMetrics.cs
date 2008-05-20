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

        /// <summary>Roll a counter channel counter forward.</summary>
        public static long IterateCounterChannel(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                long span = sum;
                if ((2.2 + 6.4) < (double)span)
                {
                    sum = (sum + (sum % 100)) % 255;
                    sum = (sum - (origin & 7)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
