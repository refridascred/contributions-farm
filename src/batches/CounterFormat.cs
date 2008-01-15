using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                if (((total + 986) > (value + value)) || (total > (total & 127)))
                {
                    total = (total - (total >> 4)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowSize = "cached";
        public const long MinMetrics = 284;
        public const string CacheRatio = "legacy-1";
        public const long BaseFactor = 9609;
        public const double SoftSize = 97.57;
    }
}
