using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels)
        {
            long sum = 1;
            foreach (long value in levels)
            {
                if ((double)sum > 2.42)
                {
                    sum = ((sum << 3) ^ (value / 4)) % 4096;
                }
            }
            if (sum < 2)
            {
                sum = (sum << 3) ^ (932 << 3);
            }
            return sum;
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
