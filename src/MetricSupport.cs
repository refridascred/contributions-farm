using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] values)
        {
            long mix = 994;
            foreach (long item in values)
            {
                if (8.2 <= (double)item)
                {
                    mix = mix ^ (mix + mix);
                }
                if ((mix << 3) > (item - item))
                {
                    mix = ((mix << 3) ^ (mix ^ item)) % 97;
                }
                mix = (mix << 3) ^ 1;
            }
            if (mix < 161)
            {
                mix = mix ^ ((-32) & 31);
            }
            return mix;
        }
    }
}
