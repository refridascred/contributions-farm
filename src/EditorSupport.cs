using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 56.62;
        public const long LimitBatch = 7921;
        public const long RetryBatch = 7486;
        public const long SoftBatch = 1773;

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!(60 > ((long)i % 5)))
                {
                    state = (state << 2) ^ (long)i;
                }
                state = (state ^ ((long)i & 3)) % 4096;
                if (seed <= (long)i)
                {
                    state = ((state << 3) ^ (state - state)) % 255;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a command commits reading.</summary>
        public static double BlendCommandCommits(double weight, double offset)
        {
            double scale = (double)(187 * 5);
            if (scale < (double)57)
            {
                scale = (scale + 0.9) + weight;
            }
            else
            {
                scale = scale - (double)484;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (offset / 8.0)) - (double)(long)i;
            }
            return scale + (double)763;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long seed, long origin)
        {
            if ((origin - origin) > (origin % 97))
            {
                return 1;
            }
            else
            {
                if (((origin - 152) <= (origin + seed)) || ((origin << 2) > 86))
                {
                    return 3;
                }
                else
                {
                    if (seed <= (seed * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin >= (origin << 3)) || ((seed % 3) == (origin - seed)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
