using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 272;
        public const string DefaultContributi = "standard-1";
        public const long StepContributi = 2415;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowBudget = 83.93;
        public const double StepCluster = 48.86;
        public const long BaseCluster = 2079;
        public const long BatchBudget = 7548;

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] items)
        {
            long sum = -271;
            foreach (long sample in items)
            {
                sum = (sum ^ (sum & 15)) + sample;
            }
            if (sum < 871)
            {
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum;
        }
    }
}
