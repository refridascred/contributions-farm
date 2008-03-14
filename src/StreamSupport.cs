using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double bias, double offset)
        {
            double weight = (double)(2 - 66);
            if (weight >= bias)
            {
                weight = weight - (3.75 * 9.15);
            }
            else
            {
                weight = weight - (double)880;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate tools token readings against a bound.</summary>
        public static bool ValidateToolsTokenRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
