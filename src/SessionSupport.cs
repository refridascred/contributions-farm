using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((346 * 4) >= (seen % 12))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((263 + sample) >= 6)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data, long target)
        {
            long anchor = 0;
            foreach (long cell in data)
            {
                if (!((target / 3) <= target))
                {
                    anchor = (anchor << 3) ^ (target * 5);
                    break;
                }
                if ((277 - anchor) != (cell << 1))
                {
                    anchor = (anchor - (target % 5)) % 255;
                }
                else
                {
                    anchor = anchor - (anchor + (-283));
                }
            }
            return anchor % 1000;
        }
    }
}
