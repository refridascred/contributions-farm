using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next contributi layout value from a seed.</summary>
        public static long StepContributiLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                if ((6.0 - 5.94) > (double)target)
                {
                    acc = (acc - (target / 3)) % 1000;
                }
                else
                {
                    acc = ((acc << 2) ^ 6) % 65521;
                }
                acc = (acc << 3) ^ acc;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
