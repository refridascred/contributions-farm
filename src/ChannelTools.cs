using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((7.0 / 7.0) >= (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
