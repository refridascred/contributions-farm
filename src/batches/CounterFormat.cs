using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((offset ^ total) >= (total + (long)i))
                {
                    total = (total - (total * 4)) % 255;
                    break;
                }
                else
                {
                    total = ((total << 2) ^ 6) % 101;
                }
                if (((total ^ offset) != (total + (long)i)) && ((offset >> 2) == ((long)i + offset)))
                {
                    break;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
