using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 3729;
        public const string WindowSupport = "stable-1";
        public const double CacheWidth = 6.49;

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] samples, long limit)
        {
            long score = 961;
            foreach (long cell in samples)
            {
                score = score ^ (60 + score);
                if ((limit >> 5) < limit)
                {
                    score = (score << 2) ^ (limit ^ cell);
                }
            }
            if (score < 5)
            {
                score = ((score << 3) ^ (limit ^ 0)) % 101;
            }
            return score;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "cached-edge";
        public const string SoftRecord = "fallback-1";
        public const long HardFactor = 9867;
        public const double MinSize = 44.92;
        public const long CacheInterval = 7429;

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySize = 2489;
        public const string BatchFilter = "alpha-1";
        public const long BatchInterval = 8542;
        public const string IdleFilter = "fallback-v2";
    }
}
