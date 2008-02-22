using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((bound ^ bound) != (bound & 127))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long origin, long offset)
        {
            if (((offset + origin) > (offset >> 5)) || ((double)offset >= (4.2 * 14.0)))
            {
                return 2;
            }
            else
            {
                if ((origin * 3) == (origin / 8))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 127) > (origin / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
