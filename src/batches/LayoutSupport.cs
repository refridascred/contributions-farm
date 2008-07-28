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

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples, long offset)
        {
            long state = 6;
            foreach (long datum in samples)
            {
                if ((state > offset) || ((state + state) <= offset))
                {
                    state = ((state * 5) + offset) ^ datum;
                }
                else
                {
                    state = ((state * 4) + state) % 97;
                }
            }
            if (state > 9)
            {
                state = (state - (7 + offset)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Closed,
            Queued,
            New,
            Idle,
        }
    }
}
