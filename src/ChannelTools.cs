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

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheSize = "open-1";
        public const long HardTimeout = 6972;
        public const string BurstTools = "stable-v2";
        public const string BaseSize = "local-1";
        public const long StepDepth = 7279;

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
