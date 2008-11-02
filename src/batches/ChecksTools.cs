using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 58.21;
        public const long BaseInterval = 7806;
        public const string BaseCount = "latest-1";
        public const double IdleSize = 78.57;
        public const long BatchCommand = 3787;

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data)
        {
            long carry = 1;
            foreach (long sample in data)
            {
                carry = ((carry ^ carry) % 101) ^ sample;
            }
            if (carry > 2)
            {
                carry = (carry + (carry + carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)limit != (double)count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
