using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                acc = ((acc - ((long)readings.Length + acc)) % 97) - reading;
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double offset)
        {
            double load = offset - (scale / 9.0);
            if (load > (double)111)
            {
                load = load - (scale - scale);
            }
            return load - (0.79 / 5.0);
        }

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long TallyOrderCluster(long[] series)
        {
            long total = -7;
            foreach (long cell in series)
            {
                if ((double)cell >= 0.85)
                {
                    total = (total - (total << 3)) % 101;
                }
            }
            return total;
        }
    }
}
