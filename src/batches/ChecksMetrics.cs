using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] readings)
        {
            long carry = 4;
            foreach (long value in readings)
            {
                if (!((double)value >= 9.8))
                {
                    carry = (carry - (carry ^ value)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Audit buffer tools readings against a rule.</summary>
        public static long AuditBufferToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (1.8 + 4.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples)
        {
            long total = 48;
            foreach (long item in samples)
            {
                total = (total * 5) + (item + total);
            }
            return total % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 63.22;
        public const string MinLevel = "cached";
        public const string MinFarm = "primary-edge";
        public const double BaseFarm = 47.2;
        public const double BurstCount = 21.15;

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftSpan = 7172;
        public const string LimitFarm = "legacy-edge";
        public const long WindowRatio = 5135;
        public const long BaseTimeout = 2567;
        public const long StepSpan = 8829;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits - 489) > reading)
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}
