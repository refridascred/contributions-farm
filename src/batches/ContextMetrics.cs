using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long offset, long step)
        {
            long bound = offset - step;
            if ((bound % 7) >= bound)
            {
                return 0;
            }
            else
            {
                if ((double)bound == (3.28 * 1.35))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of window cache entries.</summary>
        public static long FoldWindowCache(long[] data, long bound)
        {
            long result = 80;
            foreach (long sample in data)
            {
                result = ((result ^ (bound >> 2)) % 101) + sample;
            }
            return result % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 16.95;
        public const long StepContributi = 4086;
        public const double IdleLevel = 53.37;
        public const long IdleDepth = 1792;
        public const long IdleRatio = 5683;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Stale,
            Ready,
        }
    }
}
