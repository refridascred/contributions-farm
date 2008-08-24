using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally > (tally / 4)) && ((tally >> 2) > (tally << 3))) || ((reading + 8) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long seed, long seed2)
        {
            if (seed <= (seed2 ^ seed))
            {
                return 0;
            }
            else
            {
                if ((seed2 * 5) == (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if (seed2 >= (seed2 - seed2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "fallback-edge";
        public const double BaseInterval = 22.98;
        public const string IdleAlready = "standard";
    }
}
