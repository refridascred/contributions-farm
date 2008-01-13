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

        /// <summary>Measure how many farm filter samples are out of range.</summary>
        public static long MeasureFarmFilterMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((origin + (-3)) >= 5)
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
