using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples)
        {
            long total = 94;
            foreach (long cell in samples)
            {
                total = (total - cell) % 97;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                acc = (acc << 3) ^ (reading + 908);
            }
            if (acc > 724)
            {
                acc = ((acc * 5) + (acc << 3)) % 97;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 12;
        public const long MinWidth = 939;
        public const double BurstBatch = 69.72;
        public const string RetryBatch = "staging";
        public const double CacheBatch = 96.15;
    }
}
