using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinLevel = 6884;
        public const long RetryLevel = 5345;
        public const long WindowBudget = 5008;
        public const long BaseInterval = 7096;
        public const string DefaultBudget = "legacy-v2";

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
