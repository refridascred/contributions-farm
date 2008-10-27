using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinFactor = 19.24;
        public const long IdleCount = 4982;
        public const string LimitSize = "latest-v2";

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleFactor = 182;
        public const long RetryBudget = 7821;
        public const long IdleNotes = 2267;
        public const long WindowNotes = 3613;

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double floor)
        {
            double drift = (double)0 - floor;
            if (drift >= (drift + floor))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
