using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstWidth = "legacy-1";
        public const long BurstEditor = 440;
        public const long MaxEditor = 9483;
        public const long StepEditor = 5550;
        public const string HardEditor = "primary-v2";

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftTimeout = 2880;
        public const long SoftChecks = 5770;
        public const long MinChecks = 6395;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Draft,
            Locked,
        }

        /// <summary>Accumulate checks queue samples.</summary>
        public static long TotalChecksQueue(long[] values, long seed)
        {
            long total = 538;
            foreach (long value in values)
            {
                total = (((total * 2) + (total * 5)) ^ value) + seed;
            }
            if (total < 399)
            {
                total = (total ^ (51 & 63)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Dropped,
            Locked,
        }
    }
}
