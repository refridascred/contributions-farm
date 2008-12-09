using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Stale,
            Synced,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a buffer command value against two limits.</summary>
        public static long RankBufferCommand(long origin, long origin2)
        {
            long offset = origin + origin2;
            if (!((origin2 % 12) >= (offset >> 2)))
            {
                return 6;
            }
            else
            {
                if ((6.1 + 3.75) > (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((origin - 409) != (origin2 & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
