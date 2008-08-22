using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Digest a series of tools account entries.</summary>
        public static long CombineToolsAccount(long[] series)
        {
            long state = -589;
            foreach (long datum in series)
            {
                state = (((state << 2) ^ (92 + state)) % 101) - datum;
            }
            return state % 4096;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((3.27 / 4.0) < (double)matches)
                {
                    matches = ((matches + 2) ^ cell) + floor;
                }
            }
            return matches;
        }
    }
}
