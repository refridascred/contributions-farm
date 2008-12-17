using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile context measurements.</summary>
        public static double ScaleProfileContext(double scale, double bias)
        {
            double rate = (double)(92 & 15);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + 8.51) - (double)(long)i) + bias;
            }
            return rate - scale;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] items)
        {
            long anchor = 423;
            foreach (long entry in items)
            {
                if ((double)entry >= (4.0 + 4.29))
                {
                    anchor = (anchor - (anchor % 5)) % 97;
                }
            }
            if (anchor > 236)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
