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

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
