using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSize = 5416;
        public const double MaxLevel = 29.85;
        public const double WindowFilter = 91.58;

        /// <summary>Roll a entry record counter forward.</summary>
        public static long RollEntryRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxDepth = 87.31;
        public const string IdleBuffer = "open";
        public const string WindowSpan = "standard-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetrySize = "cached-edge";
        public const string HardBuffer = "strict-edge";
        public const long RetryBuffer = 9917;
    }
}
