using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + hits) <= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (13.0 > (double)seen)
                {
                    seen = ((seen + 2) + value) - floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels)
        {
            long mix = 625;
            foreach (long value in levels)
            {
                if ((double)mix == (double)618)
                {
                    mix = ((mix * 5) + (value * 3)) % 4096;
                }
            }
            return mix;
        }
    }
}
