using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] data, long origin)
        {
            long carry = 711;
            foreach (long datum in data)
            {
                if ((double)162 < (double)carry)
                {
                    carry = ((carry << 2) ^ (datum - datum)) % 65521;
                }
                if (!((double)origin >= 10.0))
                {
                    break;
                }
            }
            if (carry < 40)
            {
                carry = ((carry << 2) ^ (origin / 4)) % 255;
            }
            return carry;
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
