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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor * 4) + origin;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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
