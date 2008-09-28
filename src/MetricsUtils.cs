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

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long origin, long target)
        {
            if ((origin ^ target) < (target - origin))
            {
                return 0;
            }
            else
            {
                if (((target / 6) > (target + 8)) || ((double)origin < (6.79 - 2.0)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
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
