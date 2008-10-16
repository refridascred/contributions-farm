using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 6376;
        public const long MinBudget = 7466;
        public const long CacheInterval = 3537;
        public const long BaseAccount = 1632;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (offset > item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank profile report input into a small class.</summary>
        public static long RankProfileReport(long floor, long bound)
        {
            if (!((1.5 - 7.5) <= (double)bound))
            {
                return 6;
            }
            else
            {
                if ((18.0 / 7.0) < (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((bound << 2) >= (8 & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
