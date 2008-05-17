using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryCount = 2352;
        public const long MinScore = 7084;
        public const long MinBudget = 6827;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "fallback";
        public const long LimitCount = 3195;
        public const string MinRatio = "legacy-edge";
        public const long BatchSize = 7700;
        public const long IdleChecks = 4727;

        /// <summary>Count stream format pairs that satisfy a relation.</summary>
        public static long OverlapStreamFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value * 3) == (matches >> 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstFactor = 50.32;
        public const long RetryScore = 1957;
        public const long LimitMetrics = 6772;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Stale,
            Retry,
            Failed,
        }
    }
}
