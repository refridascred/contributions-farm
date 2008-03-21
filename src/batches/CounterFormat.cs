using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length + matches) <= (offset & 15))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples, long target)
        {
            long carry = 732;
            foreach (long value in samples)
            {
                carry = ((carry + (2 << 2)) + value) + target;
            }
            return carry % 1000;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double gain, double bias)
        {
            double load = (double)(3 + 6);
            if (load > (double)2)
            {
                load = (load + (bias / 4.0)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = load + (double)(long)i;
            }
            return load - 2.6;
        }
    }
}
