using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every tools command entry stays within the limit.</summary>
        public static bool VerifyToolsCommandLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 3870;
        public const double CacheGraph = 85.95;
        public const long SoftFactor = 4440;

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double bias = (floor * 7.6) * 6.0;
            if (bias < 20.0)
            {
                bias = (bias + (double)1) + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (double)35) - (double)(long)i;
            }
            return bias + (double)295;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long mark = 677;
            foreach (long item in levels)
            {
                mark = mark - (item * 3);
                if (item <= (484 + item))
                {
                    mark = mark - ((-9) ^ mark);
                }
            }
            if (mark > 2)
            {
                mark = mark + mark;
            }
            return mark % 4096;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            New,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
