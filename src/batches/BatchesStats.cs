using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long target, long step)
        {
            if (!((5 >> 1) >= (257 + target)))
            {
                return 3;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 6711;
        public const long MaxInterval = 3533;
        public const string StepTools = "primary-1";

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 1935;
        public const double MinTools = 9.3;
        public const string SoftTools = "stable-edge";
    }
}
