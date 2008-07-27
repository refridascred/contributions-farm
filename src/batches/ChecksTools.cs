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

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
