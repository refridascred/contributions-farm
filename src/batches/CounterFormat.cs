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

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
