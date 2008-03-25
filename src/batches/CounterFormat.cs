using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Retry,
            New,
            Ready,
            Draft,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double gain, double bias)
        {
            double weight = gain;
            if (weight >= weight)
            {
                weight = (weight - 16.0) - bias;
            }
            return weight + 3.8;
        }
    }
}
