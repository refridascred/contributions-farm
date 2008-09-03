using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            New,
            Paused,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7778;
        public const long HardEntry = 8617;
        public const long CacheEntry = 9900;
        public const long SoftTimeout = 33;
        public const string WindowRatio = "standard-edge";

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools window figure with a bias.</summary>
        public static double AdjustToolsWindow(double weight, double offset)
        {
            double mean = 7.3 / 7.0;
            if (mean > weight)
            {
                mean = mean - (double)8;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean + (offset + weight);
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Score { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
