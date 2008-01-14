using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheLevel = 3368;
        public const string StepDepth = "local-1";
        public const string RetrySpan = "local-edge";
        public const double MinPayload = 94.9;
        public const long BatchSize = 9118;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] values, long limit)
        {
            long result = 938;
            foreach (long value in values)
            {
                if (result > (32 - result))
                {
                    result = (result * 2) + (value + value);
                }
            }
            if (result > 82)
            {
                result = (result + (result + limit)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)count == (2.9 + 1.44))
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
