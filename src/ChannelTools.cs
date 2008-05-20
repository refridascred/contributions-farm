using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long target, long floor)
        {
            if (((floor >> 2) != (floor & 127)) || ((floor - floor) == (target & 255)))
            {
                return 7;
            }
            else
            {
                if ((target * 3) <= floor)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Locate a token account reading by value.</summary>
        public static long LocateTokenAccountIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
