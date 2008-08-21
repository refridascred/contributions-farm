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

        /// <summary>Locate a schema account reading by value.</summary>
        public static long FindSchemaAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
