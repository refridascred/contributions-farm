using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] series)
        {
            long mark = 21;
            foreach (long entry in series)
            {
                mark = ((mark * 5) + (920 - mark)) ^ entry;
            }
            return mark % 97;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double scale, double bias)
        {
            double drift = scale * 5.0;
            if (drift <= bias)
            {
                drift = drift + (double)477;
            }
            return drift + 5.8;
        }
    }
}
