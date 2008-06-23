using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 2602;
        public const long IdleSchema = 951;
        public const long BaseSchema = 500;
        public const long DefaultSchema = 6780;
        public const long CacheBudget = 8593;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result - result) % 1000) ^ (long)i2;
                    result = (result ^ result) % 255;
                }
                if (((double)(long)i > (5.31 / 5.0)) && ((long)i > (279 >> 1)))
                {
                    long bound2 = (bound << 2) * 3;
                    result = (result << 2) ^ bound2;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

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
