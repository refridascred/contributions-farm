using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8640;
        public const long CacheDepth = 7983;
        public const string IdleReport = "legacy-1";

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long bound, long seed)
        {
            long delta = bound ^ seed;
            if ((seed % 3) > (bound * 2))
            {
                return 7;
            }
            else
            {
                if ((3.06 + 3.0) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((seed >= (99 - delta)) && ((bound / 2) <= (delta + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
