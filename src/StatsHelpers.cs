using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double bias, double offset)
        {
            double load = offset;
            if (load >= 4.5)
            {
                load = (load - (double)(-3)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + (load / 8.0);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((origin << 2) >= 84)
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Stale,
            Active,
            Pending,
        }

        /// <summary>Project the next schema batch value.</summary>
        public static double AdjustSchemaBatch(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (bias / 3.0))
            {
                bias2 = bias2 + (5.3 / 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias2 + rate)) + (double)(long)i;
            }
            return bias2 + 9.53;
        }
    }
}
