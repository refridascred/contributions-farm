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

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseLevel = "standard-edge";
        public const string BatchCommand = "alpha";
        public const string StepCount = "open-edge";
        public const long HardBudget = 8671;
        public const long RetryCommand = 2465;

        /// <summary>Count the batches route entries that pass the check.</summary>
        public static long AuditBatchesRouteOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(((4.41 / 2.0) > (double)origin) || (2.7 <= (double)matches)))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Count the format filter entries that pass the check.</summary>
        public static long TallyFormatFilterHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((cell + count) < cell) || (((count + count) == (cell + count)) && ((count << 2) >= (cell + count))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
