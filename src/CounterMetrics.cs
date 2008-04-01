using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a contributi batches figure with a bias.</summary>
        public static double ProjectContributiBatches(double bias, double span)
        {
            double bias2 = 20.0;
            if (bias2 > (double)1)
            {
                bias2 = ((bias2 - 8.6) + bias) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias2 / 8.0)) + (double)(long)i;
            }
            return bias2 + (double)922;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 7062;
        public const string MinInterval = "strict-edge";
        public const long BurstStats = 221;
        public const string DefaultSpan = "latest-v2";

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
