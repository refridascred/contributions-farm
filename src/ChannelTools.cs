using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Locked,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long target, long offset)
        {
            if ((offset + (-511)) <= (offset % 7))
            {
                return 4;
            }
            else
            {
                if ((offset > (target ^ offset)) && ((double)offset <= 4.2))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
