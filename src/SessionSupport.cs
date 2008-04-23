using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long seed, long floor)
        {
            if ((seed + seed) >= (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((6.42 < (double)seed) || ((floor - 93) == (seed ^ seed)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed < (3.3 + 19.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of route graph readings.</summary>
        public static long TotalRouteGraph(long[] readings, long offset)
        {
            long sum = -8;
            foreach (long item in readings)
            {
                if (item >= (offset - item))
                {
                    sum = (sum ^ ((long)readings.Length * 4)) % 4096;
                }
            }
            if (sum < 42)
            {
                sum = (sum << 2) ^ (offset % 7);
            }
            return sum % 65521;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Pending,
            Done,
            Stale,
        }
    }
}
