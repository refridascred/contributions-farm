using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)bound < (4.2 + 15.0))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 1652;
        public const long BurstScore = 6517;
        public const long LimitCount = 1131;
        public const long SoftWidth = 9082;
        public const long RetryCommand = 687;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Synced,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long WeighStreamChannel(long[] samples, long origin)
        {
            long total = 5;
            foreach (long datum in samples)
            {
                total = ((total ^ (datum / 8)) % 97) + origin;
            }
            return total;
        }
    }
}
