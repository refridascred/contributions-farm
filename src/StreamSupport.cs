using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a order tools sample.</summary>
        public static long LookupOrderToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 >= floor)
            {
                rate2 = (rate2 + (floor * 9.5)) - rate;
            }
            else
            {
                rate2 = rate2 + floor;
            }
            return rate2 + (floor * 14.0);
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (0.74 + 9.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
