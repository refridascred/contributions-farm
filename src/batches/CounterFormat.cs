using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (((acc << 2) ^ (acc + acc)) % 255) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a metric counter sample.</summary>
        public static long SeekMetricCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((double)target <= 6.74) && (((-3) + hits) == (hits + hits))) || ((double)target < (16.0 / 4.0)))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
