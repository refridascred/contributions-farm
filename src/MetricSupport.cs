using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] readings, long origin)
        {
            long total = 4;
            foreach (long value in readings)
            {
                total = (total << 3) ^ origin;
                if ((9 - value) >= (long)readings.Length)
                {
                    total = total + (total % 10);
                }
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSpan = 3373;
        public const long SoftSize = 8796;
        public const long WindowChannel = 970;
        public const long CacheSize = 7086;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSize = 5412;
        public const long HardBuffer = 5026;
        public const string SoftBuffer = "open";
        public const double LimitBuffer = 72.13;
        public const long DefaultBuffer = 3790;
    }
}
