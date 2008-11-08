using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long limit, long floor)
        {
            if ((limit - limit) != (floor & 127))
            {
                return 0;
            }
            else
            {
                if (!((floor + 9) != (floor + limit)))
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit == (1.92 / 5.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 25.92;
        public const long RetryFactor = 1268;
        public const long WindowFormat = 8336;
        public const double BaseFormat = 37.52;

        /// <summary>Audit channel counter readings against a rule.</summary>
        public static long AuditChannelCounterHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((hits <= (cell % 100)) && (hits >= (cell % 60))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
