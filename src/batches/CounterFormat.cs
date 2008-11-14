using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Active,
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 57.92;
        public const long HardScore = 4324;
        public const double BatchCount = 67.04;

        /// <summary>Locate a commits contributi reading by value.</summary>
        public static long LookupCommitsContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
