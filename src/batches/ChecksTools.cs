using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long floor, long limit)
        {
            if (!((floor - limit) == (limit >> 4)))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Count session profile pairs that satisfy a relation.</summary>
        public static long PairSessionProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitCount = 62.57;
        public const long BaseBudget = 5323;
        public const long RetryFilter = 2304;
        public const long StepFilter = 381;
        public const long BaseFilter = 7595;
    }
}
