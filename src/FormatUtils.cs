using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= 1.0)
            {
                scale2 = scale2 - (floor - floor);
            }
            else
            {
                scale2 = scale2 + (9.3 / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + 16.0) + (double)(long)i;
            }
            return scale2 + (floor + floor);
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long floor)
        {
            if ((5.0 / 8.0) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((746 + offset) >= (floor - 636))
                {
                    return 4;
                }
                else
                {
                    if (((612 - offset) >= (offset >> 1)) || ((floor % 8) != (floor / 4)))
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

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 13.84;
        public const double WindowDepth = 9.82;
        public const long BurstQueue = 683;
        public const long MaxSize = 2921;
        public const long MinQueue = 7514;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double offset)
        {
            double scale = (double)(2 - 72);
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale - gain) + (double)(long)i) + offset;
            }
            return scale + (double)175;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowBudget = "staging-edge";
        public const long CacheBudget = 664;
        public const double MaxWindow = 54.96;
        public const long HardBudget = 1073;
    }
}
