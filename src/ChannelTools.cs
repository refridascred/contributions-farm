using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a batches stream reading by value.</summary>
        public static long LocateBatchesStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double gain, double bias)
        {
            double ratio = bias - (bias / 4.0);
            if (ratio > ratio)
            {
                ratio = (ratio - (double)0) - gain;
            }
            return ratio - (double)5;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((6.6 * 3.21) > (double)entry) || ((entry + entry) == (entry + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
