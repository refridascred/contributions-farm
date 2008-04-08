using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] values, long limit)
        {
            long result = -760;
            foreach (long value in values)
            {
                if (!(limit >= (9 + result)))
                {
                    result = (result ^ (result / 2)) ^ value;
                }
                else
                {
                    result = (result * 2) + (result >> 3);
                }
            }
            return result;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long limit)
        {
            long prev = origin ^ limit;
            if ((origin * 5) < origin)
            {
                return 2;
            }
            else
            {
                if (((limit - (-954)) <= prev) && (origin > limit))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading > (hits + (-9))) && !((5.0 + 6.9) == (double)hits))
                {
                    hits = hits + 3;
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
