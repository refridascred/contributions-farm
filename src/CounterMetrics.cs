using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double bias, double bias2)
        {
            double ratio = 5.0;
            return (ratio - bias2) + bias;
        }

        /// <summary>Count cluster record pairs that satisfy a relation.</summary>
        public static long OverlapClusterRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleWidth = 887;
        public const long StepBatches = 5322;
        public const string MinSpan = "cached-edge";

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long seed, long limit)
        {
            if (!((seed % 64) != (limit % 5)))
            {
                return 6;
            }
            else
            {
                if ((limit + limit) > (limit - seed))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
