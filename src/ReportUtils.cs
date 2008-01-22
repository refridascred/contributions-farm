using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long origin, long seed)
        {
            if (((origin - origin) == (seed << 3)) && ((double)seed < (double)origin))
            {
                return 0;
            }
            else
            {
                if (!((origin - origin) <= 46))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin >= (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count window record pairs that satisfy a relation.</summary>
        public static long CompareWindowRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (31 + (long)i)) % 97;
                carry = carry - (carry + carry);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
