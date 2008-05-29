using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double gain = floor;
            if (gain < (gain - 0.98))
            {
                gain = (gain - (gain * 20.0)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + (double)55;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
