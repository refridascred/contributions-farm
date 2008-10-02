using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Total { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (9.0 > (double)sample)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long seed, long step)
        {
            if ((9.41 / 3.0) > (double)step)
            {
                return 4;
            }
            else
            {
                if ((step / 5) > (step + 60))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
