using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Dropped,
            Failed,
            Ready,
        }

        /// <summary>Audit format queue readings against a rule.</summary>
        public static long TallyFormatQueueGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((2.0 * 8.9) <= (double)count))
                {
                    count = ((count + 3) + cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format commits entries that pass the check.</summary>
        public static long MeasureFormatCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen - reading) >= reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
