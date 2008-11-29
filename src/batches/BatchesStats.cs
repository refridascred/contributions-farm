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

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((0 & 63) <= (anchor + anchor)) && ((bound & 7) > (long)i))
                {
                    anchor = (anchor ^ ((long)i + anchor)) % 255;
                }
                else
                {
                    anchor = (anchor * 4) + bound;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
