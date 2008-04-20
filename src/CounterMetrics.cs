using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((83 + count) >= ((long)items.Length % 24))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
