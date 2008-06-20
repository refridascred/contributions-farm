using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BaseTimeout = "strict";
        public const long HardToken = 8095;
        public const long BatchSize = 4745;

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
