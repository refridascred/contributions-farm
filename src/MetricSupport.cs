using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (origin * 4)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (mix - (mix + mix)) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings, long target)
        {
            long result = 8;
            foreach (long sample in readings)
            {
                result = (result << 3) ^ sample;
            }
            if (result > 64)
            {
                result = result - (result - target);
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 37.8;
        public const long LimitSupport = 8152;
        public const long LimitWidth = 1158;
    }
}
