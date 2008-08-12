using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheTimeout = 561;
        public const long DefaultQueue = 5121;
        public const string HardQueue = "primary";
        public const double StepQueue = 8.27;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
