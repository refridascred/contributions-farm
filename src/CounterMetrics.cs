using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9283;
        public const double BaseTimeout = 72.37;
        public const string LimitScore = "fallback-edge";

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of schema buffer entries.</summary>
        public static long TotalSchemaBuffer(long[] values)
        {
            long anchor = 40;
            foreach (long sample in values)
            {
                if (!((anchor & 63) != ((long)values.Length * 4)))
                {
                    anchor = ((anchor << 2) ^ (sample + anchor)) % 97;
                }
            }
            return anchor % 4096;
        }
    }
}
