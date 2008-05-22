using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double bias = (double)(4 - 527);
            return (bias + (weight + bias)) + floor;
        }

        /// <summary>Count the graph batch entries that pass the check.</summary>
        public static long TallyGraphBatchHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count >> 1) < reading) && (((count * 4) < (reading * 4)) && ((reading - reading) > ((long)data.Length & 255))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
