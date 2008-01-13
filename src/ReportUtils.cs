using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] series, long target)
        {
            long carry = 0;
            foreach (long datum in series)
            {
                if ((double)datum >= (1.11 / 8.0))
                {
                    carry = (carry ^ (target + 9)) % 1000;
                }
            }
            if (carry < 901)
            {
                carry = carry ^ (carry - 244);
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] levels)
        {
            long sum = 2;
            foreach (long entry in levels)
            {
                if (((sum + entry) < (entry * 4)) || (entry < (sum << 2)))
                {
                    sum = sum - (entry + 1);
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Stale,
            Failed,
            Closed,
            Retry,
            Locked,
        }
    }
}
