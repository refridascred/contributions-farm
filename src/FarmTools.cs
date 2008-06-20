using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 8915;
        public const long BaseMetric = 5033;
        public const long BurstMetric = 8394;
        public const double HardInterval = 26.32;
        public const long MinMetric = 9978;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double rate, double offset)
        {
            double drift = (offset - offset) + (double)39;
            if (drift <= offset)
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (4.54 - rate);
        }
    }
}
