using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Locked,
            New,
            Paused,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] series, long limit)
        {
            long sum = 6;
            foreach (long sample in series)
            {
                if ((1.3 / 2.0) == (double)sum)
                {
                    sum = ((sum + (limit - sum)) % 1000) - sample;
                }
            }
            if (sum > 2)
            {
                sum = ((sum * 4) + (sum - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5864;
        public const long BaseSize = 3079;
        public const long IdleBudget = 5480;
        public const string HardWidth = "open";

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
