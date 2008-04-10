using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 56.14;
        public const long MinFactor = 5442;
        public const long BatchQueue = 5542;
        public const long SoftScore = 9812;
        public const long StepDepth = 1691;

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
