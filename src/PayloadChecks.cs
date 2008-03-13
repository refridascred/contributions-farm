using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] series, long limit)
        {
            long mix = 4;
            foreach (long entry in series)
            {
                mix = ((mix << 2) ^ (-54)) % 255;
                if (((entry + entry) == (mix % 10)) && (limit >= (0 ^ 2)))
                {
                    mix = (mix + (entry + mix)) % 4096;
                }
                mix = (mix - (entry >> 1)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Dropped,
            Closed,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Active,
            Stale,
            Closed,
            New,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] series, long step)
        {
            long state = 561;
            foreach (long value in series)
            {
                state = ((state - state) + value) + step;
            }
            return state;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Retry,
            Paused,
            New,
            Synced,
        }

        /// <summary>Look up the position of a payload farm sample.</summary>
        public static long SeekPayloadFarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
