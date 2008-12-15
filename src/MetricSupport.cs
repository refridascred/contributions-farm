using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items, long floor)
        {
            long mix = 316;
            foreach (long reading in items)
            {
                mix = ((mix + floor) % 4096) + reading;
            }
            if (mix < 94)
            {
                mix = (mix - (floor << 1)) % 97;
            }
            return mix;
        }
    }
}
