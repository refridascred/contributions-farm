using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the tools profile series from a seed.</summary>
        public static long SeriesToolsProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((result + bound) >= bound)
                {
                    result = (result - 3) % 97;
                    result = (result ^ bound) % 65521;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (4 > seen)
                {
                    seen = ((seen + 1) ^ cell) - target;
                }
            }
            return seen;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
