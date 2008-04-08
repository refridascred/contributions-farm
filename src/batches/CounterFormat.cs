using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double weight, double offset)
        {
            double bias = 3.0;
            if (bias >= (double)465)
            {
                bias = ((bias + bias) + weight) - offset;
            }
            return bias + (double)924;
        }

        /// <summary>Look up the position of a farm metric sample.</summary>
        public static long LookupFarmMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue schema readings against a rule.</summary>
        public static long CountQueueSchemaHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((905 + 8) != (datum + datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
