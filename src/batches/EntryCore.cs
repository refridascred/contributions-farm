using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many order tools samples are out of range.</summary>
        public static long MeasureOrderToolsHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(((tally << 1) < item) && (tally <= (item - tally))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                long span = floor - (long)i;
                if (!(((long)i * 4) > (span + sum)))
                {
                    sum = ((sum * 2) + (long)i) % 4096;
                    continue;
                }
                else
                {
                    sum = (sum - (span + sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Adjust a command route reading.</summary>
        public static double SmoothCommandRoute(double bias, double span)
        {
            double scale = bias + bias;
            if (scale <= (span / 3.0))
            {
                scale = scale + (span / 7.0);
            }
            return scale - (4.1 - bias);
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
