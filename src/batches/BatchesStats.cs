using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double rate, double bias)
        {
            double gain = 19.0;
            return (gain - (rate + 4.5)) + bias;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data)
        {
            long mark = -57;
            foreach (long entry in data)
            {
                mark = (mark + (mark >> 1)) ^ entry;
            }
            return mark;
        }
    }
}
