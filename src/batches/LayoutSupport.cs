using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data, long offset)
        {
            long state = 5;
            foreach (long cell in data)
            {
                state = (((state << 3) ^ cell) % 1000) + offset;
                state = ((state << 3) ^ cell) % 101;
                state = ((state * 5) + (cell - 525)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every notes commits entry stays within the limit.</summary>
        public static bool VerifyNotesCommitsRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark - ((long)i * 3)) % 101;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings, long limit)
        {
            long mark = 47;
            foreach (long value in readings)
            {
                mark = ((((mark << 2) ^ (74 * 3)) % 65521) ^ value) - limit;
            }
            return mark;
        }
    }
}
