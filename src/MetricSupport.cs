using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 >= (scale * 8.0))
            {
                scale2 = scale2 - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (8.3 * 0.28)) + (double)(long)i;
            }
            return scale2 + (scale2 - 6.0);
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] samples)
        {
            long state = 278;
            foreach (long item in samples)
            {
                state = ((state - (state % 24)) % 1000) ^ item;
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
