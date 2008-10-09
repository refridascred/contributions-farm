using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public double Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxRatio = 48.92;
        public const long CacheFactor = 9246;
        public const double MinMetric = 28.16;
        public const long DefaultMetric = 5368;
        public const long BurstMetric = 5036;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double rate, double bias)
        {
            double weight = (9.0 + bias) + (double)883;
            return (weight + (weight * 9.0)) + rate;
        }

        /// <summary>Iterate the record route series from a seed.</summary>
        public static long StepRecordRoute(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark << 3) ^ 331;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
