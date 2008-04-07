using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardRatio = 6171;
        public const string MinSize = "primary-edge";
        public const long BaseScore = 1163;
        public const double CacheSize = 58.42;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
