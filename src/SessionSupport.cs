using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit token payload readings against a rule.</summary>
        public static long AuditTokenPayloadHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample / 9) <= (target * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((result + result) != (floor - floor)))
                {
                    result = (result << 3) ^ (result - (long)i);
                    result = (result ^ (result % 64)) % 65521;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long seed)
        {
            if (!((double)seed >= (2.4 * 4.4)))
            {
                return 7;
            }
            else
            {
                if ((2.0 - 0.87) != (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
