using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long bound)
        {
            if ((offset + 840) >= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((bound ^ offset) <= (3 - bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound - bound) != (bound << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((-18) < (hits + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report tools samples are out of range.</summary>
        public static long TallyReportToolsGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((7 <= value) || ((5 & 7) <= (count ^ count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Paused,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
