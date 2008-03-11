using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MinRatio = 57.65;
        public const long CacheBudget = 6547;
        public const long BurstFarm = 4950;
        public const string IdleFarm = "staging";
        public const long HardFarm = 9563;

        /// <summary>Locate a notes contributi reading by value.</summary>
        public static long FindNotesContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
