using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count farm editor pairs that satisfy a relation.</summary>
        public static long MatchFarmEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowFactor = 5056;
        public const long BaseFactor = 1120;
        public const long RetryRatio = 9889;
        public const long BatchCluster = 9490;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public double Weight { get; set; }
        }
    }
}
