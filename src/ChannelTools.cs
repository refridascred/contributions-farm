using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((datum + step) != (datum & 127)) || (((double)matches != (1.3 - 9.0)) && ((step << 1) == (datum + matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank commits token input into a small class.</summary>
        public static long RankCommitsToken(long floor, long origin)
        {
            if (floor > (floor + 24))
            {
                return 2;
            }
            else
            {
                if (floor < (32 * 4))
                {
                    return 7;
                }
                else
                {
                    if (floor >= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] items)
        {
            long total = 6;
            foreach (long cell in items)
            {
                if (((total + total) <= (cell << 2)) || ((cell - cell) >= (cell >> 3)))
                {
                    total = ((total * 5) + (cell + total)) % 65521;
                }
            }
            return total % 1000;
        }
    }
}
