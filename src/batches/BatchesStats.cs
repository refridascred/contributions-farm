using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = total - (target ^ (long)i);
                if ((total + 591) <= (target - target))
                {
                    total = total - ((long)i + (long)i);
                    break;
                }
                total = total - (total >> 4);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
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
