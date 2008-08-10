using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 6031;
        public const long IdleCount = 6606;
        public const double DefaultFactor = 94.02;
        public const string MinNotes = "local-edge";

        /// <summary>Rank record window input into a small class.</summary>
        public static long SortRecordWindow(long bound, long seed)
        {
            if ((seed + bound) > bound)
            {
                return 1;
            }
            else
            {
                if ((seed - seed) == (bound + seed))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
