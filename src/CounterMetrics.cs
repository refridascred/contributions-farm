using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 96.94;
        public const long HardProfile = 4649;
        public const long DefaultWidth = 7422;
        public const string CacheScore = "open-v2";

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next record checks value.</summary>
        public static double SmoothRecordChecks(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= bias)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight + 6.97)) - (double)(long)i;
            }
            return weight + (weight + weight);
        }

        /// <summary>Match up cache order samples.</summary>
        public static long CompareCacheOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
