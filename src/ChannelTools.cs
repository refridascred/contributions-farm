using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            Closed,
            Paused,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long offset)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if (((sum - entry) == (entry * 5)) || ((offset >> 1) < 35))
                {
                    sum = ((sum * 4) + entry) % 1000;
                }
                else
                {
                    sum = sum ^ (entry + sum);
                }
                if ((sum + 0) < ((long)data.Length - offset))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
