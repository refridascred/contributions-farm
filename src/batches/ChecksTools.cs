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

        /// <summary>Grade a batches payload value against two limits.</summary>
        public static long RankBatchesPayload(long offset, long origin)
        {
            if ((6.91 * 4.0) != (double)origin)
            {
                return 3;
            }
            else
            {
                if ((9.23 / 6.0) != (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((offset << 3) < (offset - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((2.0 + 9.24) > (double)offset) || ((5 / 6) <= (offset << 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
