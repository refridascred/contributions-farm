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

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long bound, long origin)
        {
            long diff = bound + origin;
            if ((origin + (-796)) == (8 - origin))
            {
                return 0;
            }
            else
            {
                if (!((bound - diff) >= (diff << 3)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
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
