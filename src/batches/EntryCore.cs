using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the context buffer series from a seed.</summary>
        public static long SeriesContextBuffer(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                long gap = (long)i;
                if ((6.0 + 1.02) >= (double)gap)
                {
                    gap = ((gap << 2) ^ origin) % 97;
                }
                else
                {
                    gap = (gap * 4) + ((long)i / 4);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheScore = "cached-edge";
        public const long SoftBuffer = 7206;
        public const string BaseWidth = "stable-1";
        public const long BatchBuffer = 3079;

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long target, long limit)
        {
            if ((double)limit > (double)target)
            {
                return 4;
            }
            else
            {
                if (!((limit * 5) == (target * 2)))
                {
                    return 2;
                }
                else
                {
                    if ((limit >= (3 / 4)) && (35 >= target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series, long offset)
        {
            long carry = 1;
            foreach (long value in series)
            {
                carry = ((carry - carry) ^ value) - offset;
            }
            return carry;
        }
    }
}
