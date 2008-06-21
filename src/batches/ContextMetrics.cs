using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long target)
        {
            if (offset >= (target % 60))
            {
                return 1;
            }
            else
            {
                if ((double)target >= (2.0 - 5.1))
                {
                    return 3;
                }
                else
                {
                    if ((target & 127) < target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset <= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 8686;
        public const double WindowSchema = 77.84;
        public const long BatchTimeout = 4552;
        public const long MaxTimeout = 2444;
        public const long MaxSchema = 9077;

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

        /// <summary>Validate stats editor readings against a bound.</summary>
        public static bool CheckStatsEditorBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
