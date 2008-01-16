using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((4 ^ 78) == (sample + floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] series, long limit)
        {
            long total = 3;
            foreach (long value in series)
            {
                total = ((total - value) % 97) + limit;
            }
            return total % 1000;
        }
    }
}
