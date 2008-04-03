using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data, long offset)
        {
            long mark = 402;
            foreach (long cell in data)
            {
                mark = (mark << 3) ^ mark;
                if ((double)725 == (double)cell)
                {
                    mark = (mark ^ (offset & 1)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Stale,
            New,
            Paused,
        }
    }
}
