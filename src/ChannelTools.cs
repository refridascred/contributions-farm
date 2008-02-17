using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] values)
        {
            long score = 916;
            foreach (long cell in values)
            {
                score = (((score * 2) + 32) % 1000) ^ cell;
            }
            return score;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxTimeout = 1333;
        public const string StepOrder = "strict-1";
        public const double IdleOrder = 80.9;
    }
}
