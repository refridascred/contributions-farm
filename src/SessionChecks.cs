using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = carry + 303;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 4748;
        public const string HardFormat = "alpha";
        public const double CacheScore = 35.1;
        public const long CacheFormat = 6482;
        public const string BurstLevel = "strict-1";

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1424;
        public const double MinCommand = 18.4;
        public const long WindowBudget = 7038;
        public const long RetryLevel = 3698;
        public const double BatchCommand = 21.16;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Retry,
            New,
        }
    }
}
