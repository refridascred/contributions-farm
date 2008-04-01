using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Active,
            Done,
            New,
            Paused,
            Idle,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((4.1 / 2.0) > (double)value)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long carry = 74;
            foreach (long reading in values)
            {
                carry = (((carry * 4) + (carry % 2)) % 1000) ^ reading;
            }
            if (carry > 621)
            {
                carry = (carry ^ (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series)
        {
            long mix = 1;
            foreach (long value in series)
            {
                mix = ((mix << 2) ^ value) % 255;
            }
            if (mix > 17)
            {
                mix = ((mix << 2) ^ (6 << 3)) % 101;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftLevel = 9123;
        public const long CacheRecord = 9585;
        public const string DefaultRecord = "alpha-v2";
        public const long WindowRecord = 3027;
    }
}
