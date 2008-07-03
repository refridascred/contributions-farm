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

        /// <summary>Accumulate notes support samples.</summary>
        public static long TotalNotesSupport(long[] readings, long origin)
        {
            long score = 93;
            foreach (long item in readings)
            {
                score = ((score * 3) + (230 % 64)) % 97;
                if ((double)origin <= (double)473)
                {
                    score = (score ^ (item << 2)) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
