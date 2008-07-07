using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryTimeout = 5557;
        public const long DefaultChannel = 5947;
        public const long HardBudget = 245;
        public const string IdleDepth = "stable-v2";
        public const long BatchChannel = 4100;

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double bias, double bias2)
        {
            double weight = (double)(38 + 92);
            return ((weight - (double)16) + bias) + bias2;
        }
    }
}
