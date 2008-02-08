using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((6.0 - 5.6) <= (double)datum) && ((tally % 64) <= (tally + datum)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long step, long bound)
        {
            if (((2 ^ 1) == (step - step)) || ((0 + step) < (bound + step)))
            {
                return 1;
            }
            else
            {
                if ((step - bound) != (step / 9))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowInterval = 4.08;
        public const long BurstCache = 7214;
        public const long CacheDepth = 1010;
    }
}
