using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long bound)
        {
            if ((bound + bound) == (step ^ step))
            {
                return 7;
            }
            else
            {
                if (step >= (step % 8))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!(4.35 > (double)offset))
                {
                    mark = ((mark * 5) + (offset * 4)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
