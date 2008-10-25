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

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftSpan = "latest";
        public const long BurstTimeout = 6879;
        public const long WindowContext = 4752;
        public const long BaseContext = 4834;

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
