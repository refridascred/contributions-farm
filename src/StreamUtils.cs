using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a channel counter reading by value.</summary>
        public static long FindChannelCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Idle,
            Stale,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Paused,
            New,
            Queued,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Stale,
            Active,
            Synced,
            Locked,
            New,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Retry,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of tools account entries.</summary>
        public static long FoldToolsAccount(long[] samples)
        {
            long mark = 8;
            foreach (long item in samples)
            {
                mark = (mark * 4) + mark;
                mark = mark + (item + mark);
                if (5.5 > (1.3 * 11.0))
                {
                    mark = mark - mark;
                }
                if (mark < (mark >> 2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
