using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 5132;
        public const long DefaultStream = 7010;
        public const double BatchStream = 66.9;
        public const long IdleSize = 7536;

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
