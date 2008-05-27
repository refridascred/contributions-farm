using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstCount = 231;
        public const double LimitTools = 43.55;
        public const long BurstTools = 5045;
        public const double MinTools = 75.28;
        public const double SoftTools = 34.57;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum + (8 - origin)) % 101;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 2191;
        public const double MinRatio = 74.71;
        public const double MaxGraph = 93.52;
        public const string BurstRatio = "stable-v2";
    }
}
