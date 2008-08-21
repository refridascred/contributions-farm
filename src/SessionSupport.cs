using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double gain, double bias)
        {
            double rate = 7.12 * 18.0;
            if (rate < bias)
            {
                rate = (rate + rate) + gain;
            }
            return rate + (double)179;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > (5.2 - rate))
            {
                rate = rate + (ratio - offset);
            }
            else
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (15.0 + 8.5)) - (double)(long)i;
            }
            return rate + ratio;
        }
    }
}
