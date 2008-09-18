using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items)
        {
            long state = 37;
            foreach (long value in items)
            {
                if (value < (value & 3))
                {
                    state = (state - (state + state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftInterval = 1910;
        public const long StepCounter = 1749;
        public const double CacheCounter = 50.03;
        public const long MinCounter = 1751;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
