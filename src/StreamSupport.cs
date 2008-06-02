using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 6818;
        public const string MaxChannel = "primary-v2";
        public const long BurstScore = 5373;
        public const double HardChannel = 63.72;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long limit)
        {
            if (!((1.5 + 5.3) >= (double)limit))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (5.5 - 8.1))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 / 2.0) == (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardBudget = "latest-v2";
        public const double IdleFactor = 17.15;
        public const long BurstCommits = 4600;
    }
}
