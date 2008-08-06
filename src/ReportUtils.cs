using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate githubfarm entry samples.</summary>
        public static long TotalGithubfarmEntry(long[] readings, long limit)
        {
            long mix = 3;
            foreach (long cell in readings)
            {
                if (((mix + mix) <= (limit + limit)) || ((cell + cell) <= (mix - (-1))))
                {
                    mix = ((mix * 4) + (cell + mix)) % 101;
                }
                if ((double)cell <= (2.1 + 12.0))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Measure how many window cluster samples are out of range.</summary>
        public static long AuditWindowClusterMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((7.3 + 4.93) < (double)matches)
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long floor)
        {
            if ((693 ^ origin) <= (floor * 2))
            {
                return 2;
            }
            else
            {
                if ((double)origin < (double)91)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5800;
        public const long SoftSpan = 6102;
        public const double DefaultLevel = 12.43;
        public const long LimitRatio = 9672;
    }
}
