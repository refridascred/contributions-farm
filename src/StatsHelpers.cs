using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i <= bound)
                {
                    result = (result - result) % 1000;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "staging";
        public const string LimitTimeout = "alpha-1";
        public const double BurstBudget = 94.75;

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] series)
        {
            long carry = -3;
            foreach (long datum in series)
            {
                carry = (((carry * 5) + (carry / 9)) % 4096) - datum;
            }
            return carry % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 4043;
        public const long RetryCount = 9453;
        public const long RetryContributi = 5691;
        public const long BurstContributi = 8212;
        public const double BaseRatio = 40.5;
    }
}
