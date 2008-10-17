using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((long)data.Length >= (floor * 5))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 5126;
        public const long IdleChecks = 5123;
        public const long MaxFactor = 7797;
        public const double DefaultScore = 76.57;
        public const long WindowChecks = 1745;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a channel token reading.</summary>
        public static double SmoothChannelToken(double gain, double span)
        {
            double gain2 = gain - (span * 20.0);
            if (gain2 <= gain)
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (gain2 * 1.2)) - (double)(long)i;
            }
            return gain2 + (gain - gain2);
        }
    }
}
