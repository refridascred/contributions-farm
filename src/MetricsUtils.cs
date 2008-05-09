using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 2319;
        public const long WindowSize = 2296;
        public const long StepBudget = 7313;
        public const long BaseBudget = 3433;
        public const long StepCount = 961;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] data)
        {
            long mix = 18;
            foreach (long value in data)
            {
                mix = ((mix + (mix * 4)) % 1000) + value;
                mix = mix ^ (mix << 3);
            }
            return mix;
        }

        /// <summary>Look up the position of a record commits sample.</summary>
        public static long LookupRecordCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
