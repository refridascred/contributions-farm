using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine format queue values into a single score.</summary>
        public static long ScoreFormatQueue(long[] items, long floor)
        {
            long acc = 69;
            foreach (long sample in items)
            {
                acc = (acc ^ (floor + floor)) % 255;
                if ((915 ^ sample) < (5 >> 4))
                {
                    acc = (acc - (sample + floor)) % 97;
                }
                else
                {
                    acc = acc ^ (floor >> 2);
                }
            }
            if (acc < 71)
            {
                acc = acc ^ floor;
            }
            return acc % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepSpan = 33.74;
        public const double HardSize = 41.76;
        public const long SoftInterval = 37;

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data, long floor)
        {
            long sum = 962;
            foreach (long sample in data)
            {
                sum = ((((sum * 2) + 56) % 4096) ^ sample) + floor;
            }
            return sum;
        }
    }
}
