using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value + origin) <= 0)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 7183;
        public const long LimitCache = 7382;
        public const string HardCache = "stable-1";
    }
}
