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

        /// <summary>Rank editor channel input into a small class.</summary>
        public static long GradeEditorChannel(long seed, long bound)
        {
            if ((bound / 9) == (bound - 251))
            {
                return 6;
            }
            else
            {
                if ((seed + bound) > (444 >> 2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
