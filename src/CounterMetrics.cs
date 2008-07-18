using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Dropped,
            Closed,
            Ready,
            Done,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples, long offset)
        {
            long result = 280;
            foreach (long entry in samples)
            {
                result = (result ^ (entry ^ result)) % 4096;
                if (((result % 5) >= entry) && ((result / 3) <= (offset ^ offset)))
                {
                    break;
                }
            }
            if (result > 89)
            {
                result = (result - (result / 3)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultScore = "open-edge";
        public const long MaxSpan = 7578;
        public const long RetryRatio = 971;
        public const long StepMetric = 1715;
        public const long LimitMetric = 1816;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "local-v2";
        public const long BaseLevel = 3675;
        public const double DefaultBuffer = 81.83;
        public const string SoftInterval = "fallback";
    }
}
