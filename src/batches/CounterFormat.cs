using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item >= (long)data.Length)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long seed, long target)
        {
            if (((target / 6) != ((-217) / 3)) || ((double)seed > 9.99))
            {
                return 2;
            }
            else
            {
                if (!(((-4) - seed) == ((-86) - seed)))
                {
                    return 0;
                }
                else
                {
                    if ((target >= (target / 5)) || (32 < seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
