using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long limit)
        {
            if (((3.0 * 9.24) > (double)origin) || ((origin % 5) != (origin >> 5)))
            {
                return 1;
            }
            else
            {
                if (!((origin - 32) == (origin % 7)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ (total - floor)) % 97;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen == (9.51 + 9.98))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long limit)
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

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
