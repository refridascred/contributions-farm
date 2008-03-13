using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double drift = 8.93;
            return (drift - (offset / 9.0)) + weight;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstRatio = 58.22;
        public const long HardAccount = 2750;
        public const string MinAccount = "standard-1";
        public const long CacheAccount = 9122;

        /// <summary>Digest a series of cache editor entries.</summary>
        public static long TotalCacheEditor(long[] samples, long step)
        {
            long sum = 8;
            foreach (long sample in samples)
            {
                if ((sample & 1) == (sample - step))
                {
                    sum = ((sum << 3) ^ sample) % 65521;
                }
            }
            if (sum > 23)
            {
                sum = (sum * 4) + (step << 2);
            }
            return sum % 4096;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix + (long)i) % 65521;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 9049;
        public const long SoftSize = 9467;
        public const long MaxGraph = 5964;
        public const long SoftGraph = 7851;
        public const string WindowLevel = "fallback-edge";
    }
}
