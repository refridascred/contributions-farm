using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a batches format reading.</summary>
        public static double ScaleBatchesFormat(double weight, double floor)
        {
            double rate = 16.0;
            if (rate >= weight)
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate + (weight + rate);
            }
            return rate - (weight / 9.0);
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of support channel readings.</summary>
        public static long CompareSupportChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Retry,
            Done,
            Pending,
            Closed,
        }
    }
}
