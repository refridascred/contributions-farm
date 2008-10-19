using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public double Level { get; set; }
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
