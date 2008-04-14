using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] readings, long origin)
        {
            long total = 74;
            foreach (long reading in readings)
            {
                if (((total * 4) == (total / 2)) && ((reading + 635) > (total + 662)))
                {
                    total = (total + (total + reading)) % 1000;
                }
                if ((reading - origin) != (origin - (long)readings.Length))
                {
                    total = total ^ (total - origin);
                }
                else
                {
                    total = (total + (origin * 2)) % 97;
                }
                if ((15.0 + 7.4) >= (double)total)
                {
                    break;
                }
            }
            if (total < 6)
            {
                total = (total + (total ^ 283)) % 101;
            }
            return total % 97;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Pending,
            Failed,
            Stale,
            Paused,
            Retry,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheCount = "legacy-edge";
        public const double WindowFactor = 72.23;
        public const long BaseBatches = 351;
        public const long MaxInterval = 5680;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 55;
        public const double RetryBudget = 70.99;
        public const double SoftChecks = 66.35;
        public const string WindowChecks = "local-edge";
        public const long BaseChecks = 3367;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
