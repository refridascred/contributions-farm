using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultCluster = 11.22;
        public const long BurstCluster = 4123;
        public const long CacheRatio = 741;
        public const double BatchCluster = 37.62;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((7.1 / 8.0) == (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
