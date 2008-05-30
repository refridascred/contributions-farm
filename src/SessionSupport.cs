using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long seed)
        {
            if (!(seed <= (offset / 4)))
            {
                return 0;
            }
            else
            {
                if ((35 + offset) <= 877)
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset) >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits >= (hits >> 5))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
