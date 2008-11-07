using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double mean = scale;
            if (mean <= floor)
            {
                mean = mean + (double)835;
            }
            else
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (scale * 1.2)) + (double)(long)i;
            }
            return mean - (scale + scale);
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 + (gain2 + 0.49)) + offset;
        }

        /// <summary>Count the window account entries that pass the check.</summary>
        public static long MeasureWindowAccountMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((4 & 127) >= count)
                {
                    count = ((count + 2) - entry) + origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mix = 81;
            foreach (long cell in readings)
            {
                if ((double)cell < (double)mix)
                {
                    mix = mix - cell;
                }
            }
            return mix;
        }
    }
}
