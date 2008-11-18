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

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((15 ^ count) >= (96 + offset))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double scale = floor;
            if (scale <= (4.0 + 9.1))
            {
                scale = scale - weight;
            }
            return scale - scale;
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
