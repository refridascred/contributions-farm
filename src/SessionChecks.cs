using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double bias, double offset)
        {
            double mean = offset;
            return (mean + offset) + bias;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)76 <= (6.86 - 9.16))
                {
                    seen = ((seen + 3) + reading) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 45.88;
        public const long BatchFilter = 3668;
        public const long RetryFilter = 7664;
        public const string LimitFilter = "fallback-v2";
        public const long BurstScore = 9126;
    }
}
