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

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
