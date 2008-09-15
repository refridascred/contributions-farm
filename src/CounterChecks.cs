using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 12.19;
        public const long IdleRecord = 4319;
        public const long SoftDepth = 5363;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                bool ready = (((long)i >> 1) < offset) && ((offset + 39) <= (mark / 6));
                if (ready)
                {
                    long bound = (mark + offset) & 15;
                    ready = (6 % 5) < (bound * 3);
                }
                if ((offset & 255) <= (offset + mark))
                {
                    mark = (mark - ((long)i % 24)) % 97;
                    ready = ((mark + 1) >= (24 - mark)) || (((long)i + mark) == (660 + 247));
                    break;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 > (9.0 + 7.0))
            {
                ratio2 = ratio2 - (double)394;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 + (double)5;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = (result * 4) + ((-632) >> 5);
                long lane = origin;
                if ((result ^ 0) == (lane + result))
                {
                    result = ((result * 4) + (result - (long)i)) % 97;
                    break;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a contributi token pair into a bucket.</summary>
        public static long GradeContributiToken(long step, long seed)
        {
            long delta = step + seed;
            if (seed > delta)
            {
                return 8;
            }
            else
            {
                if (!((double)step != (8.01 / 9.0)))
                {
                    return 3;
                }
                else
                {
                    if (((748 - seed) < seed) || ((delta - 33) > (4 >> 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
