using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (7.82 + gain))
            {
                gain = (gain + (13.0 / 8.0)) + floor;
            }
            return gain - ratio;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9654;
        public const long BaseFilter = 3473;
        public const string SoftWidth = "stable-1";
        public const double MaxFilter = 40.92;
        public const long LimitTimeout = 1384;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
