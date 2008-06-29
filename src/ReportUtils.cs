using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series, long bound)
        {
            long mark = 84;
            foreach (long cell in series)
            {
                mark = (mark - (700 + 5)) % 65521;
                if (((mark + (long)series.Length) != (mark - cell)) && ((double)bound != (19.0 + 4.0)))
                {
                    mark = (mark << 3) ^ (mark % 64);
                }
            }
            if (mark > (-121))
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = score ^ (score - score);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (33 <= entry)
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a githubfarm layout sample.</summary>
        public static long LocateGithubfarmLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
