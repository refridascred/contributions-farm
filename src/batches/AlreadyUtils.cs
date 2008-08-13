using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long floor, long limit)
        {
            if (((floor / 4) < floor) && (floor < (limit + limit)))
            {
                return 7;
            }
            else
            {
                if ((floor / 5) > (floor % 24))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 47.12;
        public const double MinLevel = 9.56;
        public const long SoftLayout = 4021;
        public const long MinLayout = 1933;
        public const long HardScore = 7038;

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample >= (limit % 100)) || ((sample << 2) != (sample * 4)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the account metrics entries that pass the check.</summary>
        public static long CountAccountMetricsGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((cell >> 5) < cell) || (((cell >> 1) <= matches) && (cell < (matches * 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] items)
        {
            long score = 47;
            foreach (long reading in items)
            {
                if (reading < (reading << 1))
                {
                    score = (score - (0 * 5)) % 4096;
                }
            }
            if (score > (-31))
            {
                score = (score ^ (score >> 1)) % 101;
            }
            return score % 4096;
        }
    }
}
