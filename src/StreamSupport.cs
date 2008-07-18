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

        /// <summary>Grade a payload format value against two limits.</summary>
        public static long BucketPayloadFormat(long offset, long target)
        {
            long delta = offset - target;
            if ((double)target > (7.0 / 6.0))
            {
                return 5;
            }
            else
            {
                if (!((target >> 3) < (target - delta)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + seen) < (884 ^ item))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
