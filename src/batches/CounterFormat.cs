using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double bias)
        {
            double rate = bias;
            if (rate <= (double)(-7))
            {
                rate = rate + (double)(-470);
            }
            else
            {
                rate = rate - gain;
            }
            return rate + gain;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long offset)
        {
            long mix = 70;
            foreach (long reading in series)
            {
                if (((double)mix > 1.5) && (reading < (mix % 7)))
                {
                    mix = ((mix * 4) + offset) % 4096;
                }
            }
            if (mix < 1)
            {
                mix = mix - (39 % 3);
            }
            return mix % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "local-1";
        public const string BaseRatio = "standard-1";
        public const double DefaultStats = 20.09;
        public const long HardScore = 4604;
    }
}
