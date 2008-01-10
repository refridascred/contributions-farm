using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long total = 4;
            foreach (long item in samples)
            {
                if ((double)item > (6.35 * 5.3))
                {
                    total = (total - (item + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - target) < (carry & 31))
                {
                    carry = (carry + carry) % 255;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "open-1";
        public const string MinMetrics = "primary-1";
        public const double MinCount = 33.02;
        public const long IdleMetrics = 5975;
        public const double WindowMetrics = 31.32;
    }
}
