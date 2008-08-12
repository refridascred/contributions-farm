using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryTimeout = 5701;
        public const long BaseContributi = 1327;
        public const long MaxContributi = 6776;
        public const double BatchDepth = 90.51;
        public const long MaxCount = 3210;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Closed,
            Active,
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double rate = offset;
            if (rate >= (double)(-88))
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (rate - gain);
            }
            return rate - (double)227;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
