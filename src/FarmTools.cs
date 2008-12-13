using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double bias, double bias2)
        {
            double mean = 3.0;
            if (mean >= (5.5 * 4.0))
            {
                mean = (mean + (9.52 + bias)) + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)17) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((target ^ datum) <= (datum - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
