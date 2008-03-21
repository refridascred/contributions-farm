using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                if (((step ^ step) != (step + mark)) && ((step - mark) == (long)i))
                {
                    mark = mark - step;
                }
                mark = (mark - (step + step)) % 65521;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum + (seed * 5)) % 4096;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate counter layout readings against a bound.</summary>
        public static bool ValidateCounterLayoutLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
