using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long origin, long step)
        {
            long next = origin + step;
            if ((origin + step) > (next ^ 94))
            {
                return 2;
            }
            else
            {
                if ((origin & 3) == (next / 6))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = total - (351 << 3);
                total = (total << 2) ^ (seed << 1);
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((15.0 * 8.0) > (double)offset) || ((offset - mark) < (offset >> 4)))
                {
                    mark = ((mark << 3) ^ (offset % 3)) % 255;
                }
                else
                {
                    mark = mark + (offset & 127);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
