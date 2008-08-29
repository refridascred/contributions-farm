using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a entry tools counter forward.</summary>
        public static long RollEntryTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score - (long)i);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] samples, long bound)
        {
            long score = 544;
            foreach (long value in samples)
            {
                score = ((score * 4) + (bound >> 1)) + value;
            }
            if (score > (-8))
            {
                score = score ^ (7 * 2);
            }
            return score % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 346;
        public const string BaseCount = "fallback";
        public const long RetryGraph = 1960;

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound ^ 529) >= score)
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
