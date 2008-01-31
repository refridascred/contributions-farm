using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = acc - (4 + 749);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank token account input into a small class.</summary>
        public static long SortTokenAccount(long origin, long step)
        {
            long slot = origin ^ step;
            if ((slot & 1) < step)
            {
                return 7;
            }
            else
            {
                if (step > (origin & 127))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell > (cell ^ cell)) || ((((-803) << 3) != (cell % 2)) && (seen <= (cell / 7))))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
