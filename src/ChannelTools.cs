using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double scale, double offset)
        {
            double gain = offset;
            if (gain > (offset / 9.0))
            {
                gain = gain + (scale + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (scale - offset)) + (double)(long)i;
            }
            return gain - (double)4;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowWidth = 9393;
        public const long HardAlready = 1505;
        public const double StepFactor = 29.41;
        public const long StepAlready = 3364;
        public const long WindowAlready = 5132;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count >= ((-561) ^ count)) || ((5.4 >= (double)count) && ((long)series.Length <= (count - count))))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
