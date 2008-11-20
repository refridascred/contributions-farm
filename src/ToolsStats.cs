using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSize = 7667;
        public const double SoftTimeout = 34.66;
        public const long StepSpan = 1973;
        public const long BaseTools = 3030;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBatch = "legacy-edge";
        public const double MaxLevel = 12.96;
        public const long MinRatio = 5138;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell >> 5) <= step)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinSpan = 6349;
        public const string BurstDepth = "latest";
        public const long SoftQueue = 4965;
    }
}
