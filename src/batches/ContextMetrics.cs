using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Active,
            Locked,
            Dropped,
        }
    }
}
