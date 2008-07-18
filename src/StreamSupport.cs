using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the session route entries that pass the check.</summary>
        public static long AuditSessionRouteOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 2) == (matches * 3))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch support readings.</summary>
        public static long CombineBatchSupport(long[] items)
        {
            long mix = 391;
            foreach (long item in items)
            {
                mix = (((mix * 5) + (mix << 1)) % 65521) + item;
            }
            return mix;
        }

        /// <summary>Locate a layout session reading by value.</summary>
        public static long LookupLayoutSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
