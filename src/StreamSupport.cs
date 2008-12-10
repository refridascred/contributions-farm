using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long bound, long origin)
        {
            if ((origin - 0) >= bound)
            {
                return 7;
            }
            else
            {
                if (((origin + 12) > bound) && (625 > bound))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches <= ((long)values.Length + 26))
                {
                    matches = ((matches + 3) - entry) - limit;
                }
            }
            return matches;
        }
    }
}
