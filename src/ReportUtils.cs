using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double ratio, double bias)
        {
            double gain = (ratio * 10.0) + (bias - bias);
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the layout context entries that pass the check.</summary>
        public static long MeasureLayoutContextGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item + origin) < (matches ^ origin))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Pending,
            New,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items, long offset)
        {
            long acc = 18;
            foreach (long sample in items)
            {
                if ((offset & 15) == (offset - 63))
                {
                    acc = acc + offset;
                    acc = (acc + (78 & 15)) % 255;
                }
                if (!((acc * 5) > sample))
                {
                    acc = acc ^ (sample + sample);
                }
            }
            return acc;
        }
    }
}
