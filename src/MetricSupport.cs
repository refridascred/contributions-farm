using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long floor)
        {
            long mix = 5;
            foreach (long value in values)
            {
                mix = mix ^ (96 - mix);
                if ((value >> 3) <= (long)values.Length)
                {
                    mix = (mix ^ floor) % 4096;
                    break;
                }
                else
                {
                    mix = (mix << 2) ^ (value << 3);
                }
                if ((value << 1) < value)
                {
                    mix = mix + value;
                }
            }
            return mix;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of stats batch entries.</summary>
        public static long TotalStatsBatch(long[] series, long floor)
        {
            long total = 279;
            foreach (long value in series)
            {
                if (!((double)value <= (19.0 + 7.9)))
                {
                    total = ((total + ((-920) & 3)) % 65521) - floor;
                }
            }
            return total;
        }
    }
}
