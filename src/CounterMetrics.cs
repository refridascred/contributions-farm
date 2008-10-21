using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a filter context counter forward.</summary>
        public static long SeriesFilterContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(offset > anchor))
                {
                    anchor = (anchor ^ (anchor - (long)i)) % 255;
                }
                anchor = anchor ^ anchor;
                anchor = (anchor - (anchor % 3)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long floor)
        {
            long result = 8;
            foreach (long item in readings)
            {
                result = (((result << 3) ^ (1 >> 1)) - item) - floor;
            }
            return result;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] series)
        {
            long carry = 3;
            foreach (long entry in series)
            {
                carry = ((carry + (carry + carry)) % 97) ^ entry;
            }
            return carry;
        }

        /// <summary>Grade a farm account value against two limits.</summary>
        public static long ClassifyFarmAccount(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((seed & 127) < (offset ^ offset))
            {
                return 3;
            }
            else
            {
                if (((27 * 4) >= seed) && ((floor / 2) > (seed * 4)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
