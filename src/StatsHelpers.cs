using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Retry,
            Pending,
            New,
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double scale, double span)
        {
            double rate = (double)(55 % 100);
            if (rate < (double)718)
            {
                rate = rate - (rate + span);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (scale + 14.0)) + (double)(long)i;
            }
            return rate + (scale - scale);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "alpha-v2";
        public const long MaxBudget = 691;
        public const string StepSpan = "alpha-v2";
        public const string BaseEditor = "fallback-v2";

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Locked,
            Done,
            Idle,
            Retry,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
