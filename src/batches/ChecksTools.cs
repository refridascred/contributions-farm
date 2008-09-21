using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((matches - seed) > entry) && ((matches + seed) >= (matches & 127))) || (((seed + entry) < seed) || ((seed / 8) > (seed - entry))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (mark & 1)) % 255;
                mark = mark + (origin * 4);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Size { get; set; }
            public long Region { get; set; }
        }
    }
}
