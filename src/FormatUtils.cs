using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long origin, long seed)
        {
            if (origin <= (origin & 255))
            {
                return 8;
            }
            else
            {
                if ((origin - seed) == (seed << 1))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheLevel = 2670;
        public const long BaseCount = 7329;
        public const string StepRoute = "cached";

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((target - target) > (cell << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double scale = gain;
            if (scale <= floor)
            {
                scale = scale + (0.46 * 6.1);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)0) + (double)(long)i;
            }
            return scale - (scale - floor);
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
