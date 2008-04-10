using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many metric channel samples are out of range.</summary>
        public static long MeasureMetricChannelMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(offset <= ((long)data.Length ^ (long)data.Length)))
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
