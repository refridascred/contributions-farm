using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Count the route account entries that pass the check.</summary>
        public static long CountRouteAccountOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((double)offset < (4.0 - 6.0)) && (reading <= count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
