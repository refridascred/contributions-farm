using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long limit2)
        {
            if (!((limit + limit) <= (9 << 3)))
            {
                return 7;
            }
            else
            {
                if ((limit + limit2) != (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit % 5) < (limit2 % 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7 - 40) < (limit2 + limit2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
