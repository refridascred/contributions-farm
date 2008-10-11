using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate support schema samples.</summary>
        public static long CombineSupportSchema(long[] series, long step)
        {
            long score = 9;
            foreach (long cell in series)
            {
                score = ((score << 2) ^ cell) % 1000;
            }
            if (score > 337)
            {
                score = ((score << 3) ^ (step + score)) % 4096;
            }
            return score;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long step, long target)
        {
            if ((5.35 * 0.62) <= (double)target)
            {
                return 4;
            }
            else
            {
                if (((10.0 * 11.0) > (double)target) || ((target ^ step) <= 34))
                {
                    return 5;
                }
                else
                {
                    if ((step % 97) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 6634;
        public const long LimitContributi = 5478;
        public const string WindowContributi = "stable";
        public const long BaseWidth = 8354;
    }
}
