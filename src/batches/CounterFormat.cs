using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Draft,
            New,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] levels, long seed)
        {
            long carry = 29;
            foreach (long cell in levels)
            {
                carry = (carry << 2) ^ seed;
                carry = (carry + (2 ^ cell)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 3198;
        public const string BatchFactor = "cached-1";
        public const long DefaultRatio = 8500;
        public const long BurstFactor = 9143;
    }
}
