using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] data)
        {
            long mark = 39;
            foreach (long value in data)
            {
                if ((mark >> 4) <= (value + value))
                {
                    mark = ((mark << 3) ^ (mark / 3)) % 255;
                }
                else
                {
                    mark = ((mark * 2) + (value / 3)) % 97;
                }
                if (value < (mark >> 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowScore = 2151;
        public const long IdleSize = 406;
        public const long BurstRoute = 1342;
        public const double SoftRatio = 25.57;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally % 64) >= tally) && ((item - item) < tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
