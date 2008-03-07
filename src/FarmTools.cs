using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long target, long floor)
        {
            long cur = target - floor;
            if (((13.0 * 8.73) != (double)floor) && ((target * 4) < target))
            {
                return 6;
            }
            else
            {
                if (((target + target) < (target << 2)) && (target <= ((-81) << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((cur + cur) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target + cur) >= (target << 3)) || ((target << 1) > (target / 7)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 4386;
        public const long StepRatio = 4793;
        public const double RetryTimeout = 66.43;

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] samples, long seed)
        {
            long acc = 449;
            foreach (long cell in samples)
            {
                if (seed > (cell + acc))
                {
                    acc = acc + seed;
                }
            }
            if (acc > 8)
            {
                acc = ((acc << 3) ^ (acc >> 1)) % 97;
            }
            return acc % 97;
        }
    }
}
