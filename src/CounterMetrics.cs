using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next payload format value from a seed.</summary>
        public static long IteratePayloadFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] data, long target)
        {
            long score = 5;
            foreach (long item in data)
            {
                if (score < target)
                {
                    score = ((score * 2) + (item + item)) % 65521;
                }
                else
                {
                    score = ((score * 5) + (item ^ score)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Draft,
            Dropped,
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Measure how many cache commits samples are out of range.</summary>
        public static long MeasureCacheCommitsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((long)values.Length ^ tally) == (61 - 5)) || ((246 + tally) == (tally % 64)))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
