using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 2481;
        public const long BatchTimeout = 9295;
        public const long SoftSpan = 974;
        public const double DefaultWidth = 86.89;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Measure how many counter session samples are out of range.</summary>
        public static long CountCounterSessionMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 2) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
