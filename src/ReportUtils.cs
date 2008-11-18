using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the editor token entries that pass the check.</summary>
        public static long MeasureEditorTokenMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((8.52 - 19.0) <= (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double weight, double offset)
        {
            double drift = weight;
            if (drift >= (double)20)
            {
                drift = (drift + (drift * 0.92)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift + weight)) + (double)(long)i;
            }
            return drift + (weight * 14.0);
        }

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long CountSupportCacheGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits & 255) > 604)
                {
                    hits = ((hits + 2) ^ cell) - seed;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster filter input into a small class.</summary>
        public static long SortClusterFilter(long bound, long step)
        {
            if ((bound + 1) <= (67 - bound))
            {
                return 3;
            }
            else
            {
                if ((step - step) >= bound)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] readings)
        {
            long mark = 594;
            foreach (long sample in readings)
            {
                mark = ((mark + mark) % 4096) - sample;
            }
            return mark;
        }
    }
}
