using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 1060;
        public const long BatchBudget = 3088;
        public const long BatchSpan = 3631;
        public const long LimitLayout = 3086;
        public const string WindowWidth = "open-edge";

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long floor, long target)
        {
            if (((19.0 * 9.23) < (double)target) && ((floor % 2) != (floor ^ target)))
            {
                return 0;
            }
            else
            {
                if ((target >> 5) <= target)
                {
                    return 3;
                }
                else
                {
                    if ((target + target) < (target - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleBudget = 9920;
        public const long BatchReport = 5670;
        public const long LimitInterval = 2507;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Paused,
            Done,
        }
    }
}
