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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((double)sample >= 9.0) && ((matches & 127) < sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
