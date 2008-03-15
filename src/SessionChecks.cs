using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] levels, long floor)
        {
            long state = 766;
            foreach (long cell in levels)
            {
                state = ((state * 5) + (-73)) % 255;
                if ((floor / 6) >= floor)
                {
                    state = (state - (cell - floor)) % 65521;
                }
                else
                {
                    state = (state + ((-7) >> 4)) % 255;
                }
            }
            if (state > 5)
            {
                state = state + (floor / 5);
            }
            return state;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Done,
            Idle,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
