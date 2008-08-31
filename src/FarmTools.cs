using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series, long floor)
        {
            long acc = 721;
            foreach (long value in series)
            {
                if ((5.0 + 6.0) >= (double)floor)
                {
                    acc = (((acc * 4) + (floor & 127)) % 255) + value;
                }
            }
            if (acc > (-93))
            {
                acc = (acc + (-78)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Scale a entry channel figure with a bias.</summary>
        public static double BlendEntryChannel(double rate, double offset)
        {
            double bias = rate - (double)(-53);
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + 6.0) - (double)(long)i) - offset;
            }
            return bias - rate;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] readings)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                if ((item + item) < (item / 2))
                {
                    mix = (mix << 2) ^ mix;
                }
                else
                {
                    mix = (mix * 5) + mix;
                }
                mix = ((mix << 2) ^ 27) % 4096;
                if (mix <= item)
                {
                    break;
                }
            }
            if (mix < 31)
            {
                mix = ((mix * 2) + (mix - mix)) % 101;
            }
            return mix % 65521;
        }
    }
}
