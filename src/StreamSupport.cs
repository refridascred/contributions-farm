using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long offset, long step)
        {
            long next = offset + step;
            if (next <= (next << 2))
            {
                return 6;
            }
            else
            {
                if (((step ^ 746) <= ((-1) & 15)) && ((218 / 5) == (step << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((step + next) >= (8 * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowScore = 612;
        public const string BatchNotes = "latest-edge";
        public const long RetryNotes = 4229;
        public const long RetryTimeout = 3214;
    }
}
