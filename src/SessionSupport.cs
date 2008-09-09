using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long floor, long seed)
        {
            long span = floor - seed;
            if (((floor << 2) <= (floor * 3)) && ((seed >> 1) != (floor & 1)))
            {
                return 6;
            }
            else
            {
                if (((floor + 1) >= (floor ^ seed)) && ((double)seed >= (double)span))
                {
                    return 4;
                }
                else
                {
                    if (span < seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > (hits + 673))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data)
        {
            long total = 90;
            foreach (long item in data)
            {
                total = ((total << 3) ^ (total + 897)) % 97;
                total = (total ^ (total % 10)) % 101;
                total = (total ^ item) % 1000;
            }
            return total;
        }
    }
}
