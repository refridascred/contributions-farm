using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowFactor = "primary-1";
        public const string MaxLayout = "standard-v2";
        public const long LimitRatio = 1813;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 1008;
        public const long CacheSpan = 7348;
        public const long BaseBatches = 6405;

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double ratio = (bias - bias) + (scale * 2.5);
            return ratio - bias;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinCount = 8836;
        public const long StepRecord = 5030;
        public const long MinRecord = 2147;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(count > (value - (-89))))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
