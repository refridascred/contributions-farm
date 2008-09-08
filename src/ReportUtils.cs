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

        /// <summary>Combine support command values into a single score.</summary>
        public static long CombineSupportCommand(long[] samples)
        {
            long total = 8;
            foreach (long sample in samples)
            {
                if ((double)sample >= (double)total)
                {
                    total = (total + (sample + total)) % 1000;
                }
                else
                {
                    total = total ^ (total & 1);
                }
            }
            if (total < 7)
            {
                total = ((total << 3) ^ (36 << 1)) % 4096;
            }
            return total;
        }

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
