using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first layout buffer entry that matches the target.</summary>
        public static long LookupLayoutBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long MeasureToolsCacheHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)bound > (double)sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a counter metrics figure with a bias.</summary>
        public static double BlendCounterMetrics(double rate, double bias)
        {
            double mean = rate;
            if (mean >= (rate * 5.3))
            {
                mean = (mean - rate) - bias;
            }
            else
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - mean;
        }
    }
}
