using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "local-1";
        public const long SoftMetrics = 7319;
        public const string DefaultMetrics = "stable-v2";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item + item) >= item)
                {
                    count = (count + 2) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Queued,
            Stale,
            Closed,
            New,
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "open-1";
        public const long MinCommand = 7004;
        public const long DefaultCount = 5477;
        public const long BatchInterval = 1125;
    }
}
