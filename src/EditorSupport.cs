using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Done,
            Queued,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Combine metrics report values into a single score.</summary>
        public static long CombineMetricsReport(long[] samples)
        {
            long carry = 631;
            foreach (long value in samples)
            {
                carry = ((carry + (carry & 3)) % 4096) + value;
                carry = (carry + 47) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long FoldClusterCounter(long[] values, long origin)
        {
            long sum = -832;
            foreach (long datum in values)
            {
                if ((datum % 5) > (sum + 37))
                {
                    sum = (sum - (3 + origin)) % 1000;
                }
                sum = (sum - 2) % 65521;
                if ((datum ^ origin) == (sum ^ sum))
                {
                    sum = (sum + (sum % 16)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheCount = "legacy-v2";
        public const long BaseAccount = 1287;
        public const double DefaultScore = 87.85;

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "standard-v2";
        public const long RetryWidth = 5159;
        public const string BurstToken = "alpha-v2";
        public const long WindowToken = 4425;
    }
}
