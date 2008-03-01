using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            Active,
            New,
            Closed,
            Draft,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 1.57;
        public const double MaxCount = 35.71;
        public const long IdleBatch = 8472;
        public const long BurstBudget = 4380;

        /// <summary>Classify a account editor pair into a bucket.</summary>
        public static long BucketAccountEditor(long target, long target2)
        {
            if ((target ^ 28) == (target2 - target))
            {
                return 4;
            }
            else
            {
                if (((7.2 + 6.2) == (double)target2) && ((target2 + target) > 8))
                {
                    return 1;
                }
                else
                {
                    if ((target + target2) > 10)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinInterval = 6662;
        public const long IdleFilter = 6590;
        public const double BatchWidth = 56.56;
        public const long BatchRatio = 8302;
    }
}
