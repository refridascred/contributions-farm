using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double weight = ratio;
            if (weight <= (9.7 - floor))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + ratio;
            }
            return weight + 7.0;
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
