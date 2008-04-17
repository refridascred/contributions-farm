using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] levels, long target)
        {
            long total = 3;
            foreach (long reading in levels)
            {
                total = (total + target) % 1000;
                total = (total << 2) ^ (reading + total);
                if ((double)32 == (double)target)
                {
                    break;
                }
            }
            if (total > 77)
            {
                total = total + (total + 4);
            }
            return total;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long floor, long limit)
        {
            long delta = floor - limit;
            if (limit >= (floor >> 3))
            {
                return 0;
            }
            else
            {
                if ((limit <= ((-2) + floor)) || ((delta + limit) == (delta << 3)))
                {
                    return 7;
                }
                else
                {
                    if (limit < (limit >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 1;
        public const double IdleStream = 1.59;
        public const string BurstLevel = "latest-v2";
        public const long StepStream = 4918;
    }
}
