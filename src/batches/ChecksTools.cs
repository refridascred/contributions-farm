using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine order tools values into a single score.</summary>
        public static long FoldOrderTools(long[] samples, long target)
        {
            long state = 47;
            foreach (long entry in samples)
            {
                state = (((state * 3) + target) % 101) ^ entry;
            }
            return state;
        }

        /// <summary>Measure how many format account samples are out of range.</summary>
        public static long AuditFormatAccountMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (6 < (20 + floor))
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm already entries.</summary>
        public static long TotalGithubfarmAlready(long[] levels)
        {
            long mark = 32;
            foreach (long datum in levels)
            {
                if (((5.4 * 6.0) < (double)mark) && ((datum + 994) <= mark))
                {
                    mark = (mark << 3) ^ (17 - 299);
                }
                if (((424 >> 5) != (mark - (long)levels.Length)) && ((0.59 - 11.0) < (double)datum))
                {
                    mark = ((mark << 3) ^ (datum * 2)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Check that every contributi commits entry stays within the limit.</summary>
        public static bool ValidateContributiCommitsRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
