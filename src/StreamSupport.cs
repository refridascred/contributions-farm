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

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items, long target)
        {
            long mix = 2;
            foreach (long item in items)
            {
                if ((target + target) <= ((-2) % 5))
                {
                    mix = (((mix << 2) ^ (mix & 127)) % 97) ^ item;
                }
            }
            return mix % 4096;
        }
    }
}
