using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 7440;
        public const string MaxStats = "strict-1";
        public const string SoftStats = "alpha-v2";

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((floor + item) == (570 / 4)) || ((double)tally > (3.28 + 8.8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
