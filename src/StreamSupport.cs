using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the checks channel series from a seed.</summary>
        public static long IterateChecksChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ (43 + result);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum <= 70)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
