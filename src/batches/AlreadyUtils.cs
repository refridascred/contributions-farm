using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double rate, double offset)
        {
            double gain = (double)610 - rate;
            return gain - (offset / 8.0);
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long limit)
        {
            long offset = floor ^ limit;
            if (limit <= (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((floor & 1) == (limit / 5))
                {
                    return 6;
                }
                else
                {
                    if (((double)limit != (double)floor) || ((limit >> 5) >= (28 - 45)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit << 2) >= (offset ^ floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound + mix) <= bound)
                {
                    mix = ((mix * 5) + (bound >> 4)) % 97;
                }
                else
                {
                    mix = mix - mix;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 9906;
        public const long BaseSupport = 8951;
        public const long LimitSupport = 6918;
        public const double CacheScore = 81.55;
    }
}
