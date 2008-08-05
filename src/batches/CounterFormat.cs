using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                if ((value / 2) >= ((-78) + mix))
                {
                    mix = (mix - 988) % 255;
                    break;
                }
                else
                {
                    mix = ((mix << 2) ^ (value + value)) % 97;
                }
                mix = mix ^ (value + value);
                if (!((mix & 1) >= 834))
                {
                    mix = ((mix << 2) ^ value) % 65521;
                }
                else
                {
                    mix = mix ^ (value ^ value);
                }
            }
            if (mix > 1)
            {
                mix = mix + (mix >> 5);
            }
            return mix % 1000;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Paused,
            Pending,
        }
    }
}
