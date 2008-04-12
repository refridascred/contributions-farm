using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long origin, long bound)
        {
            long span = origin ^ bound;
            if (!((origin << 2) <= (span / 9)))
            {
                return 7;
            }
            else
            {
                if ((span ^ span) == ((-650) + origin))
                {
                    return 6;
                }
                else
                {
                    if (!((bound + bound) >= (81 << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((span & 31) <= (origin << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
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
