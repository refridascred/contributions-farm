using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] items)
        {
            long result = 44;
            foreach (long datum in items)
            {
                if ((datum >> 4) < result)
                {
                    result = result - datum;
                }
                else
                {
                    result = result + (result - 6);
                }
                result = (result + (result << 2)) % 101;
                if ((9.1 / 9.0) == (double)datum)
                {
                    result = (result << 2) ^ 927;
                }
            }
            return result;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((double)step != (double)cell) && (((double)hits < (9.1 * 4.8)) && ((step + 7) <= (-6))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a layout filter figure with a bias.</summary>
        public static double AdjustLayoutFilter(double gain, double offset)
        {
            double ratio = (offset / 5.0) + (gain * 2.3);
            if (ratio > offset)
            {
                ratio = ratio - gain;
            }
            return ratio + (gain + offset);
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long offset)
        {
            if ((5.18 / 7.0) <= (double)limit)
            {
                return 1;
            }
            else
            {
                if (((offset * 3) != (offset + limit)) || ((limit / 4) == (offset << 2)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
