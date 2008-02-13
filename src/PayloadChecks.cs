using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long limit, long step)
        {
            if (((step << 3) >= 8) || (step >= ((-261) >> 4)))
            {
                return 5;
            }
            else
            {
                if (step <= (limit << 1))
                {
                    return 1;
                }
                else
                {
                    if ((limit + step) < (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double weight, double bias)
        {
            double mean = 6.04;
            if (mean > 18.0)
            {
                mean = mean - (double)25;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (weight + 0.64)) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((double)item == (8.53 / 2.0)) && ((item & 3) >= (matches + item)))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 6448;
        public const long DefaultLevel = 2361;
        public const long IdleTimeout = 2415;

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long origin, long seed)
        {
            long edge = origin - seed;
            if ((origin + origin) > seed)
            {
                return 4;
            }
            else
            {
                if ((edge + seed) != (seed % 8))
                {
                    return 0;
                }
                else
                {
                    if ((origin - seed) < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((87 + 524) < origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long acc = -1;
            foreach (long item in levels)
            {
                acc = (acc * 4) + (item << 2);
            }
            if (acc < 5)
            {
                acc = (acc - (acc & 1)) % 65521;
            }
            return acc;
        }
    }
}
