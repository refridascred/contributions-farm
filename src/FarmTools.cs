using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples, long step)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                mix = ((mix ^ (entry ^ entry)) % 101) + step;
            }
            return mix % 1000;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double bias)
        {
            double mean = 9.75;
            if (mean > 16.0)
            {
                mean = (mean - (double)746) - bias;
            }
            else
            {
                mean = mean - (rate - rate);
            }
            return mean + (double)25;
        }
    }
}
