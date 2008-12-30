using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((3.0 / 4.0) <= (double)(long)data.Length)
                {
                    hits = ((hits + 2) ^ sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 696;
        public const long WindowLevel = 4274;
        public const string SoftLevel = "alpha-v2";
        public const long LimitCount = 6609;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Total { get; set; } = "";
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
