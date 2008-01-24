using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long seed, long floor)
        {
            long delta = seed - floor;
            if (!((seed >> 5) < (delta + 494)))
            {
                return 8;
            }
            else
            {
                if (!(floor < seed))
                {
                    return 2;
                }
                else
                {
                    if ((seed / 3) > (floor + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor & 31) <= (delta & 127))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
