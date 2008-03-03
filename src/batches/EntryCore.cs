using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                long prev = anchor + anchor;
                if ((375 ^ origin) > prev)
                {
                    prev = (prev ^ 223) % 4096;
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (2 << 1)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheScore = "cached-edge";
        public const long SoftBuffer = 7206;
        public const string BaseWidth = "stable-1";
        public const long BatchBuffer = 3079;

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long offset, long floor)
        {
            if ((390 % 60) == (offset % 12))
            {
                return 0;
            }
            else
            {
                if ((10.0 * 8.8) >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (!((double)floor <= (7.0 / 4.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] data, long offset)
        {
            long state = 8;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (state + (value - (long)i)) % 101;
                    state = (state * 5) + (value & 3);
                }
                if ((value & 3) < value)
                {
                    state = (state + (offset - offset)) % 255;
                }
            }
            if (state > 8)
            {
                state = (state - offset) % 101;
            }
            return state % 65521;
        }
    }
}
