using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long seed)
        {
            long step = floor - seed;
            if ((2 + floor) >= (step & 7))
            {
                return 5;
            }
            else
            {
                if ((seed > 9) || (floor <= (seed & 127)))
                {
                    return 2;
                }
                else
                {
                    if (((1 - step) >= floor) && ((355 - floor) < 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Synced,
            Pending,
            New,
            Ready,
            Idle,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 3) != ((-905) << 1))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
