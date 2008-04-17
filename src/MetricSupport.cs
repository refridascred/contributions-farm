using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next record batch value from a seed.</summary>
        public static long IterateRecordBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 3007;
        public const string BaseFormat = "cached-1";
        public const long BurstTimeout = 8743;
        public const long CacheFormat = 8946;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen << 2) > reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
