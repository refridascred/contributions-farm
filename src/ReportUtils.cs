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

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 4705;
        public const long MinQueue = 1694;
        public const long DefaultInterval = 708;
        public const double MaxQueue = 63.23;
        public const long SoftQueue = 9619;
    }
}
