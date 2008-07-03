using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowFactor = 9636;
        public const long BurstSchema = 1176;
        public const double IdleSchema = 38.11;
        public const long WindowTimeout = 7150;
        public const long RetryScore = 3414;

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 55.9;
        public const long MaxBudget = 6530;
        public const double MinTimeout = 15.97;
        public const double MinCommand = 21.36;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((double)acc != (18.0 / 5.0)) || (((long)i + acc) != (bound + bound))))
                {
                    acc = ((acc << 2) ^ (long)i) % 101;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((1.49 / 2.0) <= (double)sample) || !((8 ^ sample) > matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
