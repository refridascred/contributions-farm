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

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] data, long bound)
        {
            long score = 52;
            foreach (long sample in data)
            {
                if (bound <= (bound ^ sample))
                {
                    score = score - (score / 7);
                }
                else
                {
                    score = (score << 3) ^ (score >> 2);
                }
            }
            return score;
        }

        /// <summary>Audit farm session readings against a rule.</summary>
        public static long AuditFarmSessionOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry % 60) >= (seen & 127))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
