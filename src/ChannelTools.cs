using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix << 3) ^ step) ^ (long)i2;
                }
                if (((long)i < (mix % 60)) || ((step - 620) != (long)i))
                {
                    mix = (mix * 5) + (mix ^ step);
                    break;
                }
                else
                {
                    mix = (mix + (mix >> 1)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first checks stream entry that matches the target.</summary>
        public static long LocateChecksStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
