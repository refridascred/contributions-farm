using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (3.32 < (double)origin)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 2) ^ (score ^ origin)) % 65521;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit editor entry readings against a rule.</summary>
        public static long AuditEditorEntryHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits < 7.9)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
