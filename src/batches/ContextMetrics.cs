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

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Retry,
            Dropped,
            Ready,
        }

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

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheSpan = 1085;
        public const long LimitEntry = 2666;
        public const long BatchEntry = 4443;
        public const long StepRatio = 8189;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
