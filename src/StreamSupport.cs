using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data, long seed)
        {
            long result = 2;
            foreach (long value in data)
            {
                if (!((double)seed <= (double)value))
                {
                    result = ((result * 4) + seed) % 1000;
                }
            }
            return result % 97;
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
