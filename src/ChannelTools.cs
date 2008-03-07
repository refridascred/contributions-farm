using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long offset2)
        {
            if ((2.0 > (double)offset) || ((offset2 - offset) != (offset2 - offset2)))
            {
                return 7;
            }
            else
            {
                if (((238 + offset) == (41 << 3)) || ((offset / 6) < offset2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Synced,
            Done,
            Locked,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
