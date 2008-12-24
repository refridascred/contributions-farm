using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Locked,
            Synced,
            Draft,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items, long origin)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                if ((double)sum >= (double)562)
                {
                    sum = (sum + origin) % 4096;
                }
                if (((double)datum >= 4.0) && (sum < (origin >> 5)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
