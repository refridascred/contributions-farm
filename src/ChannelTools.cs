using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many checks farm samples are out of range.</summary>
        public static long MeasureChecksFarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((9 / 3) > (reading >> 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
