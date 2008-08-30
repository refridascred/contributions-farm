using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series)
        {
            long carry = 0;
            foreach (long cell in series)
            {
                if ((6.0 + 20.0) == (double)cell)
                {
                    carry = ((carry << 3) ^ (cell >> 1)) % 65521;
                }
                else
                {
                    carry = carry ^ (carry + cell);
                }
            }
            if (carry < 41)
            {
                carry = (carry ^ (carry >> 1)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Done,
            Stale,
            New,
            Draft,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster cache value against two limits.</summary>
        public static long GradeClusterCache(long seed, long target)
        {
            if ((seed * 3) != (seed << 2))
            {
                return 3;
            }
            else
            {
                if (((seed ^ target) >= (target ^ target)) || ((seed % 10) <= seed))
                {
                    return 4;
                }
                else
                {
                    if ((seed - seed) > (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target << 1) > target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a window cache counter forward.</summary>
        public static long DeriveWindowCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)origin <= (8.0 / 8.0)))
                {
                    anchor = ((anchor * 4) + ((long)i >> 5)) % 1000;
                    anchor = (anchor + origin) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
