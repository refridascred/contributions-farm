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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 6646;
        public const long HardBuffer = 8120;
        public const string WindowBuffer = "standard-v2";

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Closed,
            Idle,
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
