using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long seed, long target)
        {
            long diff = seed ^ target;
            if ((seed % 5) >= (target % 24))
            {
                return 0;
            }
            else
            {
                if ((seed - target) < diff)
                {
                    return 3;
                }
                else
                {
                    if (!((diff + 4) <= (68 * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 3080;
        public const long RetryScore = 8043;
        public const long MinSchema = 3052;

        /// <summary>Blend two graph window measurements.</summary>
        public static double AdjustGraphWindow(double rate, double floor)
        {
            double ratio = (floor * 8.85) + (double)802;
            if (ratio <= (double)(-563))
            {
                ratio = (ratio + 3.1) + rate;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i == (9.47 - 5.7))
                {
                    result = (result - (380 >> 4)) % 255;
                }
                else
                {
                    result = ((result * 2) + ((long)i + result)) % 97;
                    result = (result ^ (seed + result)) % 4096;
                }
                result = (result ^ (result & 63)) % 97;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long offset, long floor)
        {
            long cur = offset - floor;
            if (cur < offset)
            {
                return 7;
            }
            else
            {
                if (5.35 < (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (cur < (floor & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor >> 1) != (465 - (-43)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
