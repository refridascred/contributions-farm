using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((2.0 * 13.0) < (double)sample) && ((2 ^ 922) != ((long)items.Length & 31)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor ^ (anchor - floor);
                if (!((anchor + anchor) > (long)i))
                {
                    anchor = ((anchor * 5) + (anchor & 63)) % 65521;
                }
                else
                {
                    anchor = (anchor - (anchor - (long)i)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long seed, long offset)
        {
            long cur = seed ^ offset;
            if ((0 + seed) == (cur / 7))
            {
                return 1;
            }
            else
            {
                if (((offset - cur) >= seed) || ((1.2 + 1.0) > (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
