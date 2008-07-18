using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Locked,
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values)
        {
            long anchor = 4;
            foreach (long sample in values)
            {
                if (((anchor & 1) != (anchor - anchor)) || ((double)anchor < (1.23 / 4.0)))
                {
                    anchor = (((anchor << 2) ^ (32 ^ anchor)) % 255) + sample;
                }
            }
            return anchor;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
