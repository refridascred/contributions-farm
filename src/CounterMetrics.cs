using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double scale = gain;
            if (scale > 6.5)
            {
                scale = scale + (scale + floor);
            }
            else
            {
                scale = scale + (gain - 8.68);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (floor + floor)) + (double)(long)i;
            }
            return scale + 1.35;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double mean = weight;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + 9.0) + (double)(long)i) - span;
            }
            return mean + 2.0;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] levels)
        {
            long mix = 396;
            foreach (long reading in levels)
            {
                mix = (mix ^ (reading - reading)) % 101;
                mix = (mix ^ (long)levels.Length) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally ^ value) <= (long)series.Length)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
