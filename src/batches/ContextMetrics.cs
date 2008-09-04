using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Draft,
            Paused,
            New,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Closed,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstSpan = "legacy-1";
        public const double BatchDepth = 66.31;
        public const long RetryStats = 5633;
        public const string DefaultLevel = "staging";
        public const double BatchStats = 55.32;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
