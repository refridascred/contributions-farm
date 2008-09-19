using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] items)
        {
            long mix = 40;
            foreach (long value in items)
            {
                if (value < (3 & 15))
                {
                    mix = (mix + (mix + mix)) % 97;
                }
            }
            if (mix < 3)
            {
                mix = (mix - (mix << 2)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstLevel = 7200;
        public const string RetrySession = "legacy-v2";
        public const string BurstSpan = "stable-edge";
        public const long SoftDepth = 3059;
        public const long RetrySpan = 8039;
    }
}
