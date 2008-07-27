using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long floor, long limit)
        {
            long span = floor ^ limit;
            if ((6.85 - 7.24) > (double)floor)
            {
                return 0;
            }
            else
            {
                if (floor > (floor + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit + span) < (span >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7.87 * 13.0) >= (double)span)
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
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
