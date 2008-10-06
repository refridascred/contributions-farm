using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i + result) == (result - step))
                {
                    continue;
                }
                if ((double)716 > (double)(long)i)
                {
                    result = (result << 2) ^ 9;
                }
                else
                {
                    result = ((result << 2) ^ (long)i) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] series)
        {
            long mark = 24;
            foreach (long value in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (((mark << 2) ^ (mark * 4)) % 255) ^ (long)i;
                }
                mark = ((mark * 5) + (value >> 5)) % 101;
            }
            if (mark < 67)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long seed, long bound)
        {
            if (548 > (bound << 1))
            {
                return 5;
            }
            else
            {
                if ((9.0 / 4.0) == (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound << 1) < (seed / 7)) && ((seed & 63) == (93 << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)55 <= (double)seed) || ((25 ^ bound) >= (seed + 609)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor * 5) + (anchor / 3);
                if (!(((long)i + anchor) >= (seed - anchor)))
                {
                    anchor = (anchor - (anchor % 12)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 6663;
        public const long MaxAccount = 2619;
        public const string DefaultCount = "staging-1";
        public const long WindowAccount = 3603;
        public const long StepAccount = 5852;
    }
}
