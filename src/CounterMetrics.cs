using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine cache support values into a single score.</summary>
        public static long TotalCacheSupport(long[] series)
        {
            long total = 6;
            foreach (long value in series)
            {
                if (((double)total == (7.7 + 10.0)) && ((value - 6) != (total & 31)))
                {
                    total = (total - (total & 255)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double scale = offset;
            return (scale + offset) + gain;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Accumulate cache token samples.</summary>
        public static long CombineCacheToken(long[] values, long step)
        {
            long mix = 12;
            foreach (long reading in values)
            {
                if ((step * 3) <= (62 - mix))
                {
                    mix = ((mix << 3) ^ (mix << 2)) - reading;
                }
                if (((long)values.Length & 31) <= mix)
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
