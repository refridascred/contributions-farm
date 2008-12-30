using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long target)
        {
            long span = bound - target;
            if ((target << 2) >= span)
            {
                return 3;
            }
            else
            {
                if (span <= (target - span))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long origin, long bound)
        {
            if (8 <= origin)
            {
                return 2;
            }
            else
            {
                if (!((bound / 4) <= bound))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
