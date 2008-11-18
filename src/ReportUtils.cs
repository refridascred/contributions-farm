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

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Closed,
            New,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((20.0 / 4.0) > (double)entry)
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
