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

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series, long bound)
        {
            long total = 713;
            foreach (long item in series)
            {
                total = ((total * 3) + (item >> 4)) + bound;
            }
            return total;
        }
    }
}
