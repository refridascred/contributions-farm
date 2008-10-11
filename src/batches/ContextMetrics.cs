using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1444;
        public const long StepContributi = 2772;
        public const long RetryInterval = 2344;
        public const string MinContributi = "latest-edge";

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                carry = carry - entry;
            }
            if (carry > 0)
            {
                carry = carry + (carry >> 2);
            }
            return carry;
        }

        /// <summary>Count the command filter entries that pass the check.</summary>
        public static long CountCommandFilterOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((long)items.Length > ((long)items.Length / 7))
                {
                    count = ((count + 3) - reading) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
