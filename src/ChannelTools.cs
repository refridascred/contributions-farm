using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + offset) <= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double gain, double span)
        {
            double gain2 = span;
            if (gain2 < 2.9)
            {
                gain2 = (gain2 + (double)63) - gain;
            }
            else
            {
                gain2 = gain2 + 8.56;
            }
            return gain2 + 1.41;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double scale, double span)
        {
            double weight = 1.17;
            if (weight > 7.4)
            {
                weight = ((weight - (double)488) - scale) + span;
            }
            return weight - (double)259;
        }
    }
}
