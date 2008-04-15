using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ 5;
                acc = acc + (acc + bound);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (15.0 < (double)seen)
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] readings, long origin)
        {
            long anchor = 31;
            foreach (long item in readings)
            {
                anchor = ((anchor << 3) ^ (6 ^ anchor)) % 101;
                anchor = ((anchor << 3) ^ (anchor + item)) % 4096;
                if (((double)origin != (double)5) || ((18.0 * 8.7) <= (double)anchor))
                {
                    anchor = (anchor + (origin / 5)) % 4096;
                }
            }
            if (anchor < 59)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Iterate the filter farm series from a seed.</summary>
        public static long RollFilterFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample > (hits / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
