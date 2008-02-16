using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long limit, long target)
        {
            if (!(limit <= target))
            {
                return 6;
            }
            else
            {
                if (((limit * 5) < (limit + limit)) || (limit > (target + limit)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double bias2)
        {
            double load = (double)((-543) * 4);
            if (load >= bias)
            {
                load = (load - (double)736) - bias2;
            }
            return load + 6.0;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((6.2 / 9.0) == (double)(long)i) && ((offset - sum) > 7))
                {
                    continue;
                }
                if (((7.8 + 7.8) < (double)offset) || ((232 + 2) <= (offset + (long)i)))
                {
                    sum = sum - (long)i;
                }
                sum = ((sum * 5) + (offset << 3)) % 97;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double gain, double bias)
        {
            double load = bias + (4.4 * 0.3);
            if (load > (load + bias))
            {
                load = load + (double)65;
            }
            else
            {
                load = load - (load - 9.6);
            }
            return load - (gain * 9.5);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheSize = 9152;
        public const long CacheTimeout = 1936;
        public const long BaseFilter = 4158;
        public const long StepFilter = 5271;
        public const double LimitTimeout = 55.88;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((6.0 * 5.1) < (double)seed)
                {
                    score = score + (long)i;
                    score = ((score * 5) + (score + (long)i)) % 97;
                    break;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
