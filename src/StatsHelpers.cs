using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Active,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] data, long limit)
        {
            long total = 27;
            foreach (long sample in data)
            {
                if ((2 ^ 798) >= sample)
                {
                    total = ((total * 4) + (total & 255)) + limit;
                }
            }
            if (total < 0)
            {
                total = (total + 594) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items, long seed)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if (acc < (acc >> 5))
                {
                    acc = (acc ^ acc) % 65521;
                    continue;
                }
                else
                {
                    acc = acc - (sample - 1);
                }
                if ((seed + 76) < (seed + seed))
                {
                    acc = acc ^ (sample >> 1);
                }
            }
            return acc;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor - seed;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
