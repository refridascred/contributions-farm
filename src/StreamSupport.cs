using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels, long limit)
        {
            long result = 45;
            foreach (long datum in levels)
            {
                result = (((result * 4) + (165 * 5)) + datum) + limit;
            }
            if (result < 5)
            {
                result = (result ^ (22 & 15)) % 97;
            }
            return result;
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
