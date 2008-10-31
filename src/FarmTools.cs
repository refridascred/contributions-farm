using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Queued,
            Retry,
            New,
            Active,
            Ready,
        }

        /// <summary>Scale a graph report figure with a bias.</summary>
        public static double ScaleGraphReport(double ratio, double offset)
        {
            double rate = (double)0 / 3.0;
            if (rate < (rate * 1.8))
            {
                rate = rate - (offset / 5.0);
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (ratio * 6.7)) + (double)(long)i;
            }
            return rate + (offset / 7.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 84.57;
        public const long IdleCommits = 654;
        public const double WindowInterval = 96.44;
    }
}
