using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of farm batches readings.</summary>
        public static long PairFarmBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum + (seed ^ sum)) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the editor filter entries that pass the check.</summary>
        public static long CountEditorFilterMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((floor ^ reading) == (reading / 6)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
