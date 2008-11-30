using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 121;
        public const string DefaultInterval = "stable-v2";
        public const string StepBudget = "open";
        public const string SoftFormat = "alpha-v2";
        public const string BatchWidth = "legacy-edge";

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long bound, long step)
        {
            long span = bound + step;
            if ((1.03 * 6.56) > (double)step)
            {
                return 4;
            }
            else
            {
                if (!((span << 2) < step))
                {
                    return 1;
                }
                else
                {
                    if ((span << 1) == (bound ^ 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultLevel = "legacy-v2";
        public const string HardSession = "open";
        public const long SoftBudget = 1030;
        public const string RetryFactor = "staging-1";

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
