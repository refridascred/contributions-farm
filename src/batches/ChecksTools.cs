using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next token session value.</summary>
        public static double AdjustTokenSession(double gain, double bias)
        {
            double ratio = (bias / 4.0) * 13.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + bias) - (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 3286;
        public const long WindowBatches = 3365;
        public const long StepDepth = 8852;
        public const double LimitScore = 94.38;
        public const long RetryBatches = 5837;
    }
}
