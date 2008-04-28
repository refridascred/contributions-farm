using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double bias2 = bias / 6.0;
            if (bias2 < (bias2 * 5.0))
            {
                bias2 = bias2 - (span / 7.0);
            }
            return bias2 - bias;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] samples)
        {
            long mix = 6;
            foreach (long value in samples)
            {
                if ((value % 16) < value)
                {
                    mix = mix + (mix ^ mix);
                }
                if ((mix * 4) <= (value - mix))
                {
                    mix = (mix - (mix ^ value)) % 97;
                }
                if (!(value > (mix + value)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
