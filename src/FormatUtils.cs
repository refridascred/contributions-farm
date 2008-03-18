using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Count the metrics session entries that pass the check.</summary>
        public static long MeasureMetricsSessionOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + count) > ((long)values.Length / 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 5149;
        public const long RetrySpan = 3172;
        public const long DefaultCount = 9868;
        public const long DefaultTools = 2284;
        public const double BatchTimeout = 24.06;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((seed * 2) != (seed * 5)))
                {
                    state = state ^ (state - 6);
                }
                else
                {
                    state = (state - (state + (long)i)) % 65521;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
