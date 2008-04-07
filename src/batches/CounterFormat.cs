using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double ratio, double span)
        {
            double rate = (span + span) * 0.4;
            if (rate < ratio)
            {
                rate = rate + rate;
            }
            return rate - (ratio - span);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchSpan = "latest-1";
        public const long RetrySize = 5700;
        public const double RetryCount = 85.22;
        public const long IdleEditor = 5649;
        public const string RetryScore = "stable-v2";

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Active,
            Stale,
        }
    }
}
