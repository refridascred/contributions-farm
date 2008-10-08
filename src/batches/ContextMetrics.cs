using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchLevel = 48.72;
        public const string DefaultBatches = "fallback-v2";
        public const string BaseBatches = "cached-v2";
        public const string BurstLevel = "cached-1";
        public const double SoftBatches = 38.14;

        /// <summary>Measure how many order layout samples are out of range.</summary>
        public static long MeasureOrderLayoutHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen - (-918)) != (cell ^ cell))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((5.6 + 9.2) >= (double)sample)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
