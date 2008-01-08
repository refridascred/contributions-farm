using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of editor notes readings.</summary>
        public static long TotalEditorNotes(long[] levels, long origin)
        {
            long anchor = 45;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 2) ^ (origin ^ anchor)) % 4096) - reading;
                anchor = (anchor ^ (9 + anchor)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = (total + (total << 2)) % 255;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
