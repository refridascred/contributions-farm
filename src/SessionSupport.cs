using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long seed, long bound)
        {
            long slot = seed - bound;
            if ((16.0 / 8.0) <= (double)bound)
            {
                return 4;
            }
            else
            {
                if (((bound << 1) > (bound ^ slot)) && ((double)bound != (8.08 / 9.0)))
                {
                    return 7;
                }
                else
                {
                    if (((seed - seed) < (slot + bound)) && ((slot & 3) >= (bound % 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((((-2) + seed) < (seed >> 4)) || ((bound / 6) >= (seed * 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Closed,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
