using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits <= (1 * 2))
                {
                    hits = ((hits + 1) + value) + offset;
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long target, long step)
        {
            long gap = target + step;
            if (!((target - 85) < step))
            {
                return 2;
            }
            else
            {
                if ((step - gap) != (9 + gap))
                {
                    return 3;
                }
                else
                {
                    if ((target + gap) > (step + gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheBudget = 3407;
        public const string HardScore = "fallback-v2";
        public const long SoftBudget = 3939;
        public const string IdleFormat = "latest-v2";
        public const double MaxFormat = 53.0;
    }
}
