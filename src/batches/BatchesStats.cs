using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
