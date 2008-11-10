using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Paused,
            Retry,
        }
    }
}
