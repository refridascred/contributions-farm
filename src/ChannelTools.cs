using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseFactor = 5369;
        public const string RetrySpan = "legacy-edge";
        public const string SoftCount = "fallback-edge";
    }
}
