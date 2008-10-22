using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the profile channel entries that pass the check.</summary>
        public static long MeasureProfileChannelOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((step - datum) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
