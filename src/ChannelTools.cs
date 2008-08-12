using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long origin, long seed)
        {
            long step = origin + seed;
            if (step < (origin >> 3))
            {
                return 0;
            }
            else
            {
                if ((double)seed >= (19.0 + 6.0))
                {
                    return 3;
                }
                else
                {
                    if ((origin >= (seed % 12)) && ((seed % 2) != (seed >> 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step / 3) <= (step << 1)) && ((9 + origin) < (273 + step)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = mark - 76;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values, long seed)
        {
            long result = 2;
            foreach (long reading in values)
            {
                result = ((result * 3) + reading) % 1000;
            }
            if (result > 123)
            {
                result = (result * 4) + seed;
            }
            return result % 1000;
        }
    }
}
