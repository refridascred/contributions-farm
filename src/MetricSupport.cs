using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowTimeout = 6721;
        public const long MinGraph = 2715;
        public const long IdleLevel = 4582;

        /// <summary>Locate a tools batch reading by value.</summary>
        public static long SeekToolsBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Retry,
            Idle,
            Active,
            Dropped,
        }
    }
}
