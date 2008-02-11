using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the record channel series from a seed.</summary>
        public static long StepRecordChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                long tally = floor + (mark >> 4);
                if ((((long)i % 12) != (long)i) || (((long)i - 54) >= tally))
                {
                    mark = ((mark << 3) ^ mark) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long floor)
        {
            if (((double)45 <= (double)seed) || (floor >= (floor + 3)))
            {
                return 8;
            }
            else
            {
                if ((floor / 4) <= (seed - seed))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i + bound) <= (bound / 3))
                {
                    total = (total + (total + bound)) % 4096;
                    break;
                }
                total = (total + (bound - total)) % 97;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
