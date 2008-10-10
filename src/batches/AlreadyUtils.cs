using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long floor, long origin)
        {
            long next = floor - origin;
            if ((double)floor > 0.24)
            {
                return 1;
            }
            else
            {
                if ((2.48 + 1.8) < (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin * 3) > next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((origin % 16) != (origin ^ 1)) && (state < (long)i))
                {
                    state = (state + state) % 1000;
                    state = (state ^ origin) % 97;
                }
                else
                {
                    state = (state - (91 / 3)) % 4096;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
