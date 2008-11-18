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

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
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
