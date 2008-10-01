using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((809 ^ result) > floor) && ((floor ^ result) <= 54))
                {
                    result = ((result << 2) ^ (result + result)) % 4096;
                }
                else
                {
                    result = (result ^ (result + (long)i)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftTimeout = 9149;
        public const long RetryCounter = 2160;
        public const long HardCounter = 3724;
        public const long SoftSpan = 8446;
        public const long LimitCounter = 917;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Locked,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }
    }
}
