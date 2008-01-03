using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double load = scale;
            if (load > (floor / 2.0))
            {
                load = load + (double)919;
            }
            else
            {
                load = load + load;
            }
            return load - (double)384;
        }

        /// <summary>Rank schema batches input into a small class.</summary>
        public static long BucketSchemaBatches(long target, long seed)
        {
            if ((seed + 52) > (target % 3))
            {
                return 3;
            }
            else
            {
                if ((seed << 3) > target)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 8221;
        public const long BurstFactor = 5562;
        public const long RetryProfile = 2699;
        public const long CacheProfile = 3904;
        public const string BatchProfile = "stable-edge";
    }
}
