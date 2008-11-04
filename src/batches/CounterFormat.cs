using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] levels, long step)
        {
            long carry = 22;
            foreach (long value in levels)
            {
                if ((value + step) > (-5))
                {
                    carry = (carry * 5) + value;
                }
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long step)
        {
            if (((double)offset <= 8.8) || ((step ^ offset) >= offset))
            {
                return 6;
            }
            else
            {
                if ((step + offset) <= (offset ^ step))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
