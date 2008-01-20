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

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples, long target)
        {
            long anchor = 155;
            foreach (long entry in samples)
            {
                if ((entry <= (entry * 4)) || ((entry - entry) < (entry ^ 19)))
                {
                    anchor = ((anchor + (2 % 5)) % 4096) - target;
                }
            }
            return anchor;
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
