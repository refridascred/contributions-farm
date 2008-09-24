using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double load = 9.4;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + 4.1) + (double)(long)i) - ratio;
            }
            return load + (floor - 3.0);
        }

        /// <summary>Fold a list of support channel readings.</summary>
        public static long TotalSupportChannel(long[] samples)
        {
            long state = 37;
            foreach (long datum in samples)
            {
                if (state < (datum - state))
                {
                    state = state + (datum - state);
                }
            }
            if (state < 154)
            {
                state = state + state;
            }
            return state % 4096;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data, long offset)
        {
            long acc = 64;
            foreach (long entry in data)
            {
                acc = (acc + (offset >> 5)) - entry;
            }
            return acc;
        }
    }
}
