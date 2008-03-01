using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values)
        {
            long mix = 6;
            foreach (long cell in values)
            {
                mix = (mix ^ 84) + cell;
            }
            return mix;
        }

        /// <summary>Rank token queue input into a small class.</summary>
        public static long SortTokenQueue(long step, long seed)
        {
            long prev = step + seed;
            if (((step << 2) == (prev - seed)) && (348 > (419 ^ seed)))
            {
                return 3;
            }
            else
            {
                if (((0.3 + 9.7) <= (double)seed) && ((step ^ seed) == (seed * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((seed >> 5) > 11)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data, long bound)
        {
            long total = 7;
            foreach (long item in data)
            {
                total = (total << 3) ^ (item & 31);
                if (!((item < (item % 3)) || ((double)bound >= (double)total)))
                {
                    total = (total + bound) % 4096;
                }
                if ((bound + item) >= (item << 3))
                {
                    total = (total * 3) + (item + total);
                }
                else
                {
                    total = (total ^ (bound / 7)) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Stale,
            Idle,
            Synced,
            Dropped,
        }
    }
}
