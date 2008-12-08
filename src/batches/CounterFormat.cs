using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count == (7.7 - 3.99))
                {
                    count = ((count + 3) ^ value) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i == (seed >> 5))
                {
                    acc = (acc * 3) + acc;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
