using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of commits notes entries.</summary>
        public static long CombineCommitsNotes(long[] readings)
        {
            long mix = -6;
            foreach (long value in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (((mix * 2) + (-751)) % 4096) - (long)i;
                }
                if ((0.2 + 4.7) >= (double)mix)
                {
                    mix = (mix ^ value) % 1000;
                }
            }
            if (mix < 6)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item + 37) <= hits)
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
