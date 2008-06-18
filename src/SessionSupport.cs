using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long seed, long floor)
        {
            if (((floor + floor) < (floor % 97)) || ((double)floor > (12.0 * 20.0)))
            {
                return 5;
            }
            else
            {
                if ((floor * 2) <= (floor << 2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Queued,
            Active,
        }
    }
}
