using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value >> 2) > (value << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "local-edge";
        public const long HardSize = 1312;
        public const long BatchBuffer = 8054;
        public const long BurstLevel = 5544;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] data, long step)
        {
            long state = -5;
            foreach (long value in data)
            {
                state = (state - value) % 255;
                if (step < (step - value))
                {
                    state = state - (value - value);
                }
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseFactor = 8836;
        public const long BaseMetrics = 7285;
        public const long DefaultMetrics = 706;
    }
}
