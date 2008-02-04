using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 3619;
        public const long DefaultInterval = 513;
        public const long WindowLayout = 8699;
        public const double BatchRatio = 90.65;

        /// <summary>Find the first batches graph entry that matches the target.</summary>
        public static long FindBatchesGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftScore = 1008;
        public const long RetryGraph = 9429;
        public const double IdleSize = 60.88;
        public const double BaseGraph = 66.73;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Queued,
            Paused,
            Draft,
            Failed,
            Synced,
        }
    }
}
