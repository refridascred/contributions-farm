using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long floor)
        {
            if ((double)(-90) < (double)floor)
            {
                return 4;
            }
            else
            {
                if (!(((-48) - 371) < floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 2) == (floor * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
