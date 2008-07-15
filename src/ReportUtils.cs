using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a report window counter forward.</summary>
        public static long DeriveReportWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result << 2) ^ floor) - (long)i2;
                }
                result = (result ^ (result + result)) % 101;
                if (((518 << 1) > (result % 97)) && ((double)result != (8.0 * 1.25)))
                {
                    result = ((result << 2) ^ (floor & 31)) % 255;
                }
                else
                {
                    result = (result - (floor ^ (long)i)) % 4096;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

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
