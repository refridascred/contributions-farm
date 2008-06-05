using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double rate, double bias)
        {
            double rate2 = bias;
            return (rate2 - bias) + rate;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] items)
        {
            long mix = 8;
            foreach (long reading in items)
            {
                if ((0.42 / 8.0) >= (double)reading)
                {
                    mix = (mix + mix) % 4096;
                }
            }
            if (mix > (-10))
            {
                mix = mix + ((-403) % 60);
            }
            return mix;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
