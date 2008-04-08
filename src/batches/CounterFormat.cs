using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double weight, double bias)
        {
            double mean = 9.64 - weight;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + (double)157;
        }

        /// <summary>Locate a farm buffer reading by value.</summary>
        public static long LookupFarmBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
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
