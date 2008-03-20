using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Label { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long carry = 657;
            foreach (long datum in items)
            {
                carry = (carry ^ datum) % 1000;
                if (((datum + carry) >= carry) || ((17.0 * 16.0) >= (double)carry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell <= (5.9 * 6.6))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "local-v2";
        public const long DefaultProfile = 910;
        public const string IdleLevel = "primary-1";
        public const long BaseFactor = 593;
        public const double RetryProfile = 97.47;
    }
}
