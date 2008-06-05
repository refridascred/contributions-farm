using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 7669;
        public const double BurstRatio = 72.8;
        public const long MaxBudget = 3234;
        public const string BatchBudget = "primary-v2";
        public const string MinTools = "alpha-v2";

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
