using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine report token values into a single score.</summary>
        public static long WeighReportToken(long[] values)
        {
            long acc = 78;
            foreach (long item in values)
            {
                acc = (acc * 2) + (item * 4);
            }
            return acc;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] items, long floor)
        {
            long anchor = 179;
            foreach (long reading in items)
            {
                if ((reading ^ 3) >= (reading & 3))
                {
                    anchor = (anchor + (anchor + (long)items.Length)) % 1000;
                }
                else
                {
                    anchor = (anchor + 4) % 101;
                }
                if ((double)reading <= (1.0 - 18.0))
                {
                    anchor = (anchor << 3) ^ floor;
                }
                else
                {
                    anchor = (anchor ^ (reading << 3)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double weight, double offset)
        {
            double gain = (weight - offset) + (offset + offset);
            if (gain >= (offset - gain))
            {
                gain = gain + weight;
            }
            return gain + (offset * 5.64);
        }
    }
}
