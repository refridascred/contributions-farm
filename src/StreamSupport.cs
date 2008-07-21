using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings)
        {
            long mark = 0;
            foreach (long entry in readings)
            {
                mark = (((mark << 3) ^ (127 << 3)) % 65521) - entry;
                if ((mark + mark) >= (mark % 5))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark * 3) + (mark + 7);
            }
            return mark;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + 420) % 1000;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next support cache value from a seed.</summary>
        public static long RollSupportCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum - (floor & 1)) % 4096;
                sum = sum ^ 3;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
