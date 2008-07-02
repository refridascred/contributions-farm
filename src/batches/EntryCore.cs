using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Locked,
            Paused,
            Pending,
        }

        /// <summary>Locate a stream queue reading by value.</summary>
        public static long LookupStreamQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
