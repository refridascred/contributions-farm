using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double bias = scale;
            if (bias >= (scale * 7.7))
            {
                bias = bias + 1.0;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - scale) - (double)(long)i;
            }
            return bias + (offset + bias);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxBudget = 6392;
        public const long StepSchema = 2056;
        public const long CacheSchema = 871;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)reading == (7.0 * 5.9)))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Rank format profile input into a small class.</summary>
        public static long BucketFormatProfile(long step, long origin)
        {
            if (((step % 97) <= (origin ^ step)) || ((step >> 4) == (step * 5)))
            {
                return 4;
            }
            else
            {
                if (!((6.1 * 8.7) >= (double)step))
                {
                    return 2;
                }
                else
                {
                    if (!((9 / 3) == (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
