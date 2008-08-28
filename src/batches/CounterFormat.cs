using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long limit, long origin)
        {
            if (origin < (origin / 2))
            {
                return 8;
            }
            else
            {
                if (((origin % 16) >= (limit + limit)) && (476 > (origin ^ 54)))
                {
                    return 7;
                }
                else
                {
                    if (limit <= (96 ^ origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.25 - 4.23) < (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
