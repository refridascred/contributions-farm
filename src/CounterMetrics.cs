using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double floor)
        {
            double drift = (weight - 12.0) / 3.0;
            if (drift > (double)282)
            {
                drift = (drift - weight) + floor;
            }
            return drift + 7.2;
        }

        /// <summary>Measure how many context stream samples are out of range.</summary>
        public static long MeasureContextStreamOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits - reading) != (reading - 94))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] data, long bound)
        {
            long carry = 1;
            foreach (long item in data)
            {
                if (!((item - (long)data.Length) > (carry + bound)))
                {
                    carry = ((carry * 3) + carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of cluster token entries.</summary>
        public static long ScoreClusterToken(long[] readings, long bound)
        {
            long anchor = 21;
            foreach (long datum in readings)
            {
                anchor = ((anchor ^ (0 - anchor)) - datum) - bound;
            }
            if (anchor > 54)
            {
                anchor = ((anchor * 4) + (anchor >> 1)) % 65521;
            }
            return anchor;
        }
    }
}
