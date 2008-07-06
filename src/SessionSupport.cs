using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result - seed) % 101) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a format batches value against two limits.</summary>
        public static long GradeFormatBatches(long seed, long offset)
        {
            if ((offset & 7) > (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (12.0 / 2.0))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank channel support input into a small class.</summary>
        public static long RankChannelSupport(long origin, long offset)
        {
            if ((double)origin >= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)origin == (9.0 * 7.0))
                {
                    return 7;
                }
                else
                {
                    if (((17.0 * 2.82) == (double)origin) && ((double)offset == (10.0 + 9.8)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
