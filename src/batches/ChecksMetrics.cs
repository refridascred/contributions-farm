using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long TotalToolsQueue(long[] data, long step)
        {
            long sum = 6;
            foreach (long entry in data)
            {
                sum = sum - (entry + sum);
                sum = (sum - (step + sum)) % 4096;
                sum = sum ^ (entry - 935);
            }
            if (sum < 197)
            {
                sum = ((sum << 3) ^ (3 ^ 86)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 9176;
        public const double RetryWidth = 85.96;
        public const long WindowFilter = 3737;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Pending,
            Dropped,
            Closed,
        }
    }
}
