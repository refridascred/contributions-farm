using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long offset)
        {
            if ((double)target >= (7.0 / 3.0))
            {
                return 8;
            }
            else
            {
                if ((target & 3) > offset)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit notes cluster readings against a rule.</summary>
        public static long TallyNotesClusterMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell % 16) > cell)
                {
                    hits = (hits + 3) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm queue samples.</summary>
        public static long CombineFarmQueue(long[] items)
        {
            long result = 97;
            foreach (long value in items)
            {
                if (((2.81 / 6.0) < (double)result) && (((long)items.Length % 8) <= (result / 7)))
                {
                    result = result + (value + 6);
                }
            }
            return result % 1000;
        }
    }
}
