using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many order record samples are out of range.</summary>
        public static long MeasureOrderRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count < (long)items.Length)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((68 % 8) > limit)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Ready,
            Draft,
            Synced,
            Closed,
            New,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2088;
        public const double SoftInterval = 71.24;
        public const long BaseCount = 9101;
    }
}
