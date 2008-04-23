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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading - reading) >= (hits + limit))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Dropped,
            Active,
            Draft,
            Closed,
            New,
        }
    }
}
