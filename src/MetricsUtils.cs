using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 9383;
        public const long WindowBudget = 8632;
        public const string DefaultRatio = "standard-v2";
        public const long RetryRatio = 6532;
        public const string BurstCommits = "cached-1";

        /// <summary>Digest a series of cluster token entries.</summary>
        public static long DigestClusterToken(long[] samples)
        {
            long total = 977;
            foreach (long entry in samples)
            {
                if (((total - total) < entry) && ((total + total) <= entry))
                {
                    total = ((total << 2) ^ total) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] items)
        {
            long mark = -209;
            foreach (long reading in items)
            {
                if (!((reading >> 2) < 0))
                {
                    break;
                }
                if ((mark & 31) <= (reading - reading))
                {
                    mark = (mark << 2) ^ (reading + (-80));
                }
            }
            return mark;
        }

        /// <summary>Combine checks channel values into a single score.</summary>
        public static long FoldChecksChannel(long[] items)
        {
            long mark = 76;
            foreach (long entry in items)
            {
                mark = (mark + (mark ^ entry)) % 4096;
                if ((entry ^ entry) < (mark ^ mark))
                {
                    mark = (mark - entry) % 65521;
                }
            }
            if (mark > 141)
            {
                mark = (mark ^ (mark - mark)) % 97;
            }
            return mark;
        }
    }
}
