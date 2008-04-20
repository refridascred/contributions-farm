using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 87.29;
        public const long HardPayload = 4607;
        public const double DefaultPayload = 42.42;
        public const double CacheSpan = 15.11;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long target, long floor)
        {
            if ((target & 255) == (target % 3))
            {
                return 0;
            }
            else
            {
                if ((double)target <= (6.11 / 7.0))
                {
                    return 4;
                }
                else
                {
                    if (floor >= (71 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)seen > (6.29 / 9.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
