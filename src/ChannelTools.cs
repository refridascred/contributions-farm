using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a checks tools pair into a bucket.</summary>
        public static long ClassifyChecksTools(long step, long offset)
        {
            long delta = step ^ offset;
            if ((2.64 - 2.6) <= (double)delta)
            {
                return 4;
            }
            else
            {
                if (((3.4 - 2.6) == (double)step) || ((111 ^ offset) <= delta))
                {
                    return 6;
                }
                else
                {
                    if (((delta + offset) > (step / 8)) && (delta >= (step ^ offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
