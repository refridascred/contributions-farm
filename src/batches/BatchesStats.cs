using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many format cluster samples are out of range.</summary>
        public static long CountFormatClusterHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches & 7) >= (932 * 2))
                {
                    matches = ((matches + 1) - item) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "standard-1";
        public const long SoftDepth = 3095;
        public const long MinRatio = 2513;
        public const long HardFactor = 5362;
        public const long StepStream = 4157;

        /// <summary>Validate queue window readings against a bound.</summary>
        public static bool ValidateQueueWindowBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
