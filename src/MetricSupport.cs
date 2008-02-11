using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series, long limit)
        {
            long mix = 36;
            foreach (long sample in series)
            {
                mix = ((mix << 2) ^ (sample >> 3)) - limit;
            }
            if (mix > 85)
            {
                mix = (mix + (176 * 4)) % 255;
            }
            return mix % 1000;
        }
    }
}
