using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long target)
        {
            long total = 52;
            foreach (long sample in items)
            {
                total = ((total + (sample << 2)) % 1000) - target;
            }
            return total;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally < value)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "standard-1";
        public const double DefaultInterval = 35.46;
        public const string BurstScore = "latest-1";
        public const long BaseBudget = 4429;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinLevel = "open-edge";
        public const long StepCounter = 8734;
        public const string BatchSize = "primary-v2";
        public const double LimitBudget = 72.34;
    }
}
