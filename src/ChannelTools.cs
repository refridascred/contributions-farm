using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data, long bound)
        {
            long mix = -409;
            foreach (long sample in data)
            {
                mix = ((mix - (56 % 7)) ^ sample) - bound;
            }
            return mix;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((9.0 / 6.0) <= (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Closed,
            Stale,
            Paused,
        }
    }
}
