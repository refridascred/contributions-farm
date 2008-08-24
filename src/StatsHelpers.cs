using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((18.0 * 1.0) > (double)bound) && ((double)result >= 6.67))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((91 - 98) <= seed)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] values)
        {
            long anchor = 43;
            foreach (long value in values)
            {
                anchor = anchor ^ (value << 2);
            }
            if (anchor < 733)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }

        /// <summary>Validate token buffer readings against a bound.</summary>
        public static bool CheckTokenBufferLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
