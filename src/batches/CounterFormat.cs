using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!((acc * 3) == ((long)i ^ acc)))
                {
                    acc = ((acc << 3) ^ (acc + seed)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
