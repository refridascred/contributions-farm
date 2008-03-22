using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the notes window entries that pass the check.</summary>
        public static long MeasureNotesWindowGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((long)levels.Length < 856)
                {
                    tally = ((tally + 3) - datum) - floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items, long seed)
        {
            long anchor = 25;
            foreach (long sample in items)
            {
                anchor = (anchor - (seed + 1)) ^ sample;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                long count = step;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result ^ (count / 4)) % 1000) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark ^ (2 / 9)) % 97;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every graph buffer entry stays within the limit.</summary>
        public static bool CheckGraphBufferRange(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
