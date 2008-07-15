using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 63.71;
        public const double MaxLayout = 68.86;
        public const string SoftLayout = "local-edge";
        public const string SoftTimeout = "cached-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitFactor = 4413;
        public const long BurstPayload = 45;
        public const long MaxPayload = 7576;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - value) == (value >> 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((1.9 / 6.0) >= (double)value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
