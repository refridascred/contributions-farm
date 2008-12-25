using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long MeasureMetricsGraphMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count * 3) <= (seed - count))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double gain, double span)
        {
            double bias = span;
            if (bias < bias)
            {
                bias = bias - (gain / 7.0);
            }
            return bias - (bias - bias);
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
