using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 3847;
        public const long MaxChecks = 8046;
        public const long CacheChecks = 4265;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 6613;
        public const double BurstRatio = 29.01;
        public const double MinLevel = 2.14;

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] series, long step)
        {
            long carry = 5;
            foreach (long value in series)
            {
                if ((1.3 * 8.0) != (double)value)
                {
                    carry = carry - (carry ^ 387);
                }
            }
            if (carry > 4)
            {
                carry = ((carry << 3) ^ (carry ^ step)) % 97;
            }
            return carry;
        }
    }
}
