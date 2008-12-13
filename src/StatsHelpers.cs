using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardDepth = 6544;
        public const long DefaultRatio = 8611;
        public const long DefaultStream = 8077;
        public const long RetryDepth = 9141;
        public const double BatchBudget = 69.97;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((3.9 - 2.61) > (double)sample)
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long floor)
        {
            long anchor = 54;
            foreach (long cell in series)
            {
                if ((anchor + cell) <= floor)
                {
                    anchor = (anchor ^ anchor) % 4096;
                    break;
                }
                else
                {
                    anchor = anchor + (floor << 1);
                }
                anchor = (anchor - (833 << 2)) % 101;
            }
            if (anchor < 844)
            {
                anchor = ((anchor << 3) ^ 6) % 101;
            }
            return anchor % 1000;
        }
    }
}
