using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftDepth = 1208;
        public const long StepSpan = 5526;
        public const long LimitCounter = 1897;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
