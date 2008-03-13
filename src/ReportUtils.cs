using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double ratio, double floor)
        {
            double bias = 3.5;
            return (bias + (floor * 7.18)) + ratio;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepScore = "primary";
        public const long CacheEditor = 8892;
        public const long IdleInterval = 9090;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long limit, long target)
        {
            long bound = limit + target;
            if ((bound & 31) < limit)
            {
                return 5;
            }
            else
            {
                if ((0.94 / 9.0) != (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long offset)
        {
            long step = seed ^ offset;
            if (offset >= seed)
            {
                return 4;
            }
            else
            {
                if ((double)offset < 5.1)
                {
                    return 2;
                }
                else
                {
                    if (offset <= (offset & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >= (seed - step)) && ((617 ^ seed) != (step + seed)))
                        {
                            return 5;
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
}
