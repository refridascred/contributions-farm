using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double gain = bias;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)(long)i) - offset;
            }
            return gain + (double)64;
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
