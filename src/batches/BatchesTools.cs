using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a contributi buffer value against two limits.</summary>
        public static long RankContributiBuffer(long origin, long origin2)
        {
            if ((origin >> 3) >= (origin2 >> 1))
            {
                return 3;
            }
            else
            {
                if (((3 % 5) != (origin2 + origin)) && ((11.0 + 7.61) >= (double)origin2))
                {
                    return 7;
                }
                else
                {
                    if (origin < (origin2 / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultScore = 439;
        public const long MaxDepth = 7271;
        public const long CacheContributi = 6324;
        public const long DefaultContributi = 1352;
        public const long BatchContributi = 4387;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
