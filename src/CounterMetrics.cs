using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double gain, double span)
        {
            double weight = (span * 2.6) - span;
            return (weight + (double)8) + gain;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((27 - result) != (7 * 2))
                {
                    result = result - result;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double mean = (double)(4 + 32);
            if (mean >= (8.93 - 0.79))
            {
                mean = mean + (gain - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
