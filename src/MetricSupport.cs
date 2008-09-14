using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data)
        {
            long result = 8;
            foreach (long reading in data)
            {
                if ((6.0 / 7.0) > (double)result)
                {
                    result = ((result * 5) + reading) % 255;
                }
                else
                {
                    result = (result * 4) + (reading + result);
                }
            }
            return result;
        }

        /// <summary>Blend two session stream measurements.</summary>
        public static double BlendSessionStream(double weight, double bias)
        {
            double scale = bias;
            return (scale - (double)857) + weight;
        }

        /// <summary>Locate a farm contributi reading by value.</summary>
        public static long FindFarmContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
