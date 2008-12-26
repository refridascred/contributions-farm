using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((2.38 / 7.0) >= (double)bound)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((48 - datum) != (3 + 9))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Synced,
            Draft,
            Done,
            Stale,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] series, long step)
        {
            long sum = 941;
            foreach (long cell in series)
            {
                if (step > (87 / 5))
                {
                    sum = (sum * 3) + sum;
                }
                else
                {
                    sum = (sum + (step + cell)) % 65521;
                }
            }
            return sum;
        }
    }
}
