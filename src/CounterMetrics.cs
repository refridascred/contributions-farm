using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of commits support entries.</summary>
        public static long TotalCommitsSupport(long[] data)
        {
            long score = 5;
            foreach (long entry in data)
            {
                score = ((score * 4) + entry) % 65521;
                score = (score + (entry * 2)) % 1000;
                if ((entry > (entry >> 3)) || ((11.0 - 1.0) != (double)score))
                {
                    break;
                }
            }
            return score;
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
