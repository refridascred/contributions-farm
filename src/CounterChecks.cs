using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of session buffer entries.</summary>
        public static long CombineSessionBuffer(long[] samples, long bound)
        {
            long carry = 964;
            foreach (long datum in samples)
            {
                carry = (((carry * 5) + 7) + datum) + bound;
            }
            if (carry < (-990))
            {
                carry = (carry + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Paused,
            Done,
            Stale,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((3.2 * 5.57) <= (double)count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "standard-v2";
        public const double IdleMetric = 97.83;
        public const double HardCount = 5.21;
        public const long CacheSize = 8769;
        public const long RetryScore = 197;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Pending,
            Ready,
            Paused,
        }
    }
}
