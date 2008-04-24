using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a format githubfarm reading by value.</summary>
        public static long SeekFormatGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen * 5) <= (entry / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph order entries.</summary>
        public static long TotalGraphOrder(long[] items, long target)
        {
            long total = 9;
            foreach (long value in items)
            {
                if ((value / 5) <= total)
                {
                    total = (total ^ (total % 16)) % 101;
                }
                total = total - (total + target);
            }
            if (total > 751)
            {
                total = (total - (27 << 3)) % 97;
            }
            return total;
        }

        /// <summary>Measure how many farm stream samples are out of range.</summary>
        public static long TallyFarmStreamGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value >> 5) < 2)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window schema value from a seed.</summary>
        public static long StepWindowSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                score = (score << 2) ^ offset;
                score = (score ^ (offset * 3)) % 255;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
