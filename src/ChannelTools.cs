using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double drift = bias;
            if (drift >= (drift - bias))
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (7.11 - bias)) + (double)(long)i;
            }
            return drift + (double)(-781);
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] data, long offset)
        {
            long mix = 16;
            foreach (long cell in data)
            {
                if ((cell * 3) < offset)
                {
                    mix = (mix + mix) % 4096;
                    break;
                }
                if (mix < (cell - (long)data.Length))
                {
                    mix = mix + (mix & 7);
                }
            }
            return mix;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Locked,
            Pending,
            Paused,
            Closed,
        }
    }
}
