using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double ratio = span;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - weight;
            }
            return ratio + (ratio + span);
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double gain = weight - (double)66;
            if (gain < bias)
            {
                gain = gain + weight;
            }
            return gain - (bias / 2.0);
        }

        /// <summary>Look up the position of a already editor sample.</summary>
        public static long LocateAlreadyEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics checks entries.</summary>
        public static long ScoreMetricsChecks(long[] series)
        {
            long mark = 95;
            foreach (long entry in series)
            {
                if ((mark / 3) > (long)series.Length)
                {
                    mark = (mark << 3) ^ (mark + entry);
                }
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell >= (origin - count)) && (((-96) & 3) > (cell * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
