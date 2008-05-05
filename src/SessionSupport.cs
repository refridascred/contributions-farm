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

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] items, long step)
        {
            long carry = 86;
            foreach (long reading in items)
            {
                carry = (((carry << 3) ^ reading) % 255) - step;
            }
            return carry;
        }
    }
}
