using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double scale, double bias)
        {
            double scale2 = (double)(122 & 3);
            if (scale2 < (bias - scale))
            {
                scale2 = scale2 - (double)2;
            }
            else
            {
                scale2 = scale2 - scale;
            }
            return scale2 - scale2;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] levels, long step)
        {
            long score = -555;
            foreach (long item in levels)
            {
                score = (score ^ score) ^ item;
                if ((624 - step) == (31 / 5))
                {
                    break;
                }
            }
            if (score > 29)
            {
                score = score - score;
            }
            return score % 97;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series)
        {
            long state = 60;
            foreach (long cell in series)
            {
                long offset = (long)series.Length;
                state = (state * 2) + (32 - offset);
                if ((state << 2) >= (cell % 2))
                {
                    state = (state * 4) + state;
                }
            }
            if (state < 9)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long seed, long origin)
        {
            long diff = seed + origin;
            if (origin >= (seed << 2))
            {
                return 8;
            }
            else
            {
                if ((diff - (-799)) < (origin << 3))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = (state ^ (state * 2)) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count * 3) != (count & 255))
                {
                    count = ((count + 1) ^ datum) + origin;
                }
            }
            return count;
        }
    }
}
