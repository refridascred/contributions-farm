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

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "local-edge";
        public const long MinStream = 6790;
        public const double StepStream = 33.0;
        public const long IdleStream = 2507;
        public const long DefaultLevel = 7551;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
