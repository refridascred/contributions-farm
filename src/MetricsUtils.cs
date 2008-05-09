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

        /// <summary>Derive the next token stream value from a seed.</summary>
        public static long IterateTokenStream(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                long lane = ((long)i / 8) + (target + target);
                if (((double)(long)i >= (15.0 - 4.8)) || (target > (lane + (long)i)))
                {
                    lane = (lane ^ state) % 1000;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
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
