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

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = mark + (seed + mark);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (((mark * 5) + seed) % 1000) ^ (long)i2;
                }
                mark = (mark << 3) ^ (seed & 127);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
