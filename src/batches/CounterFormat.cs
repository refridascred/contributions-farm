using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(410 < cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
