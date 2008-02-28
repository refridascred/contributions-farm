using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples)
        {
            long mix = 34;
            foreach (long sample in samples)
            {
                if ((mix & 255) < (mix - mix))
                {
                    mix = (mix << 3) ^ (sample + sample);
                }
                else
                {
                    mix = (mix + (sample - (long)samples.Length)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)entry > (18.0 * 7.37)) && ((entry << 2) == (27 * 3)))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitCount = 1364;
        public const long MinWindow = 9655;
        public const long BaseWindow = 9738;
    }
}
