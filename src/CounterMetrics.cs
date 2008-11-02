using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 609;
        public const long MinWidth = 8151;
        public const long HardRatio = 7988;
        public const long MaxWidth = 1419;
        public const long DefaultTimeout = 464;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepCount = "local-edge";
        public const long DefaultCount = 3421;
        public const double BaseFilter = 3.9;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
