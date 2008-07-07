using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 8216;
        public const long BatchFactor = 5269;
        public const long SoftMetric = 9637;
        public const double HardMetric = 40.4;
        public const string MaxSpan = "stable-v2";

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                score = ((score << 2) ^ score) % 255;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples, long seed)
        {
            long score = 848;
            foreach (long cell in samples)
            {
                if ((9.7 / 2.0) <= (double)seed)
                {
                    score = ((score - ((-83) - seed)) % 1000) + cell;
                }
            }
            if (score < 8)
            {
                score = ((score << 3) ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitBudget = 9037;
        public const long BaseLevel = 7998;
        public const string CacheContributi = "stable-v2";
        public const long BatchBudget = 3325;
        public const double SoftContributi = 13.01;
    }
}
