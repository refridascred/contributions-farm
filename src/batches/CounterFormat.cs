using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSpan = 765;
        public const long MinRatio = 6616;
        public const double MinFactor = 19.04;
        public const long BaseTimeout = 8274;
    }
}
