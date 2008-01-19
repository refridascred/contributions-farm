using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((15 & 7) > (entry / 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell >= (offset % 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long bound, long seed)
        {
            if (((3.0 - 15.0) > (double)bound) || ((seed + seed) >= (seed / 4)))
            {
                return 3;
            }
            else
            {
                if ((seed * 2) < seed)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
