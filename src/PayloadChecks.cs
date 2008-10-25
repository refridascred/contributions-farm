using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 4975;
        public const long HardSize = 6300;
        public const string BaseTimeout = "cached-edge";

        /// <summary>Accumulate metrics batches samples.</summary>
        public static long TotalMetricsBatches(long[] values, long offset)
        {
            long carry = 82;
            foreach (long item in values)
            {
                if ((offset + carry) < (item % 100))
                {
                    carry = carry ^ offset;
                }
            }
            return carry;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many cache channel samples are out of range.</summary>
        public static long AuditCacheChannelGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((target >> 3) != (datum << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            Active,
            Draft,
            Retry,
            Dropped,
        }
    }
}
