using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next layout token value.</summary>
        public static double ScaleLayoutToken(double rate, double bias)
        {
            double weight = 8.44 - bias;
            if (weight <= (rate + bias))
            {
                weight = weight - (double)186;
            }
            return weight - rate;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetrySpan = 9610;
        public const long DefaultCount = 7899;
        public const long BaseScore = 683;
        public const long MaxCache = 8256;
        public const string SoftTimeout = "cached";

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Active,
            Failed,
            Closed,
            Synced,
        }
    }
}
