using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((2.8 - 1.96) <= (double)count)
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Audit cache already readings against a rule.</summary>
        public static long CountCacheAlreadyHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((sample + matches) <= (matches % 8)) && (sample >= (sample ^ matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the notes batch entries that pass the check.</summary>
        public static long TallyNotesBatchGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((double)seen >= (double)49))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
