using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + reading) >= (count - reading))
                {
                    count = count + 1;
                }
            }
            return count;
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
