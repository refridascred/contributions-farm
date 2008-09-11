using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 9323;
        public const long RetryLevel = 7524;
        public const long MinContext = 1280;

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double ratio, double floor)
        {
            double scale = (double)8 * 1.7;
            return ((scale - (double)83) + ratio) + floor;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
