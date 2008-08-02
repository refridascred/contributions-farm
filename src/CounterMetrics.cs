using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two metric account measurements.</summary>
        public static double ScaleMetricAccount(double weight, double offset)
        {
            double weight2 = offset - weight;
            if (weight2 >= (offset - weight))
            {
                weight2 = weight2 - weight;
            }
            else
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (weight2 / 5.0)) + (double)(long)i;
            }
            return weight2 + (weight - weight);
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Adjust a queue metric reading.</summary>
        public static double ProjectQueueMetric(double rate, double offset)
        {
            double mean = (double)(20 & 127);
            if (mean <= (0.2 + offset))
            {
                mean = (mean + (offset / 2.0)) - rate;
            }
            return mean + (mean / 5.0);
        }
    }
}
