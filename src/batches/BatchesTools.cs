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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
