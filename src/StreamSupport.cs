using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two graph batches measurements.</summary>
        public static double SmoothGraphBatches(double bias, double bias2)
        {
            double weight = bias;
            if (weight <= 4.4)
            {
                weight = weight - (double)0;
            }
            else
            {
                weight = weight - (bias2 + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (weight + weight)) - (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values)
        {
            long acc = -9;
            foreach (long cell in values)
            {
                if ((88 >> 2) < (acc >> 4))
                {
                    acc = ((acc << 2) ^ (cell & 7)) % 1000;
                }
                if (cell < (acc + (long)values.Length))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
