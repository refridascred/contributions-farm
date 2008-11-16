using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next stats contributi value.</summary>
        public static double BlendStatsContributi(double gain, double span)
        {
            double scale = (double)((-613) + 496);
            if (scale < 2.3)
            {
                scale = scale + (span + 2.02);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
