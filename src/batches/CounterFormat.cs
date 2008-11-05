using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((double)offset > (8.66 - 9.7))
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report batch value.</summary>
        public static double ScaleReportBatch(double scale, double bias)
        {
            double mean = bias / 9.0;
            if (mean <= (double)0)
            {
                mean = (mean - (mean - mean)) - scale;
            }
            return mean - (bias / 9.0);
        }
    }
}
