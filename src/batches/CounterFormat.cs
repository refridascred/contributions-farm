using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a route notes pair into a bucket.</summary>
        public static long GradeRouteNotes(long offset, long step)
        {
            long cur = offset ^ step;
            if ((offset / 3) > (14 << 2))
            {
                return 2;
            }
            else
            {
                if ((cur / 8) > (cur / 2))
                {
                    return 5;
                }
                else
                {
                    if ((step * 2) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                long prev = anchor + (seed + seed);
                if (6 > seed)
                {
                    prev = (prev << 2) ^ (anchor >> 5);
                }
                if ((anchor + prev) >= (anchor + seed))
                {
                    prev = prev + ((long)i - prev);
                }
                else
                {
                    prev = (prev * 4) + (anchor + 54);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultDepth = 9264;
        public const long MinCommand = 9826;
        public const string IdleCommand = "alpha-1";
        public const long BatchSpan = 6498;
        public const long MaxCommand = 5600;
    }
}
