using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "open-1";
        public const long StepWindow = 1651;
        public const long MaxSpan = 541;
        public const long HardDepth = 1765;
        public const long DefaultScore = 5242;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Pending,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Draft,
            New,
            Closed,
            Pending,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] series)
        {
            long total = 693;
            foreach (long reading in series)
            {
                total = ((total + (286 - total)) % 1000) + reading;
            }
            if (total > 75)
            {
                total = ((total * 5) + (total / 5)) % 1000;
            }
            return total;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
