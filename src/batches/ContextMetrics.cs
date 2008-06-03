using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Failed,
            Paused,
            Done,
            Draft,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long origin, long offset)
        {
            if (((double)offset >= (double)66) || ((5.41 / 8.0) != (double)origin))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (9.88 - 5.6))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate channel farm readings against a bound.</summary>
        public static bool ValidateChannelFarmLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
