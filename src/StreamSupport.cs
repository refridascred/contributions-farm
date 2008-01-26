using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 3945;
        public const long IdleSize = 5053;
        public const long MaxCount = 8617;
        public const long RetryInterval = 2432;

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double bias)
        {
            double ratio = bias - (4.9 + bias);
            if (ratio > (rate / 8.0))
            {
                ratio = ratio + (ratio / 6.0);
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (ratio - rate);
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Retry,
            Draft,
            Synced,
        }
    }
}
