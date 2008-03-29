using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long floor, long seed)
        {
            if ((16 + floor) > (372 / 9))
            {
                return 7;
            }
            else
            {
                if (((seed % 16) == (seed ^ seed)) || (seed >= (seed >> 3)))
                {
                    return 5;
                }
                else
                {
                    if ((9.51 * 3.0) > (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 80.77;
        public const long CacheCount = 3490;
        public const long BatchChecks = 1117;
        public const long CacheSize = 3299;
        public const double CacheDepth = 14.74;

        /// <summary>Measure how many support stream samples are out of range.</summary>
        public static long CountSupportStreamOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((5.9 / 2.0) <= (double)floor)
                {
                    seen = (seen + 2) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < (double)977)
            {
                ratio = (ratio - ratio) + bias;
            }
            return ratio - (0.4 / 2.0);
        }
    }
}
