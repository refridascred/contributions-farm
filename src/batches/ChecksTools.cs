using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the session route entries that pass the check.</summary>
        public static long CountSessionRouteMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(entry > hits))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Match up session token samples.</summary>
        public static long CompareSessionTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate already token samples.</summary>
        public static long TotalAlreadyToken(long[] items)
        {
            long result = 0;
            foreach (long entry in items)
            {
                if ((entry % 2) != (result + entry))
                {
                    result = result + (entry % 12);
                }
                if ((entry + result) >= result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] levels, long target)
        {
            long state = 234;
            foreach (long reading in levels)
            {
                state = ((((state << 2) ^ 17) % 97) - reading) - target;
                state = ((state * 5) + (state >> 2)) % 1000;
            }
            if (state < (-2))
            {
                state = state + state;
            }
            return state;
        }
    }
}
