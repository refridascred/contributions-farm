using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double gain, double offset)
        {
            double drift = offset * 7.65;
            if (drift < (drift + offset))
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift - (gain / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 9.48) + (double)(long)i;
            }
            return drift + (double)0;
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
