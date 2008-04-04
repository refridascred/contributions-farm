using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of already entry entries.</summary>
        public static long TallyAlreadyEntry(long[] data)
        {
            long carry = 6;
            foreach (long item in data)
            {
                if (!(carry <= item))
                {
                    carry = carry ^ (carry & 31);
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] data, long seed)
        {
            long mix = 78;
            foreach (long reading in data)
            {
                mix = (((mix * 5) + (mix - seed)) % 101) ^ reading;
                mix = (mix + (63 / 8)) % 255;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 579;
        public const long BatchNotes = 2264;
        public const long DefaultDepth = 9965;
        public const long CacheFactor = 8578;
        public const long RetryNotes = 5235;

        /// <summary>Audit graph support readings against a rule.</summary>
        public static long TallyGraphSupportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (7.0 + 6.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a editor profile reading by value.</summary>
        public static long SeekEditorProfileIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
