using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 3689;
        public const long LimitPayload = 7487;
        public const string MinPayload = "fallback-1";
        public const double CachePayload = 26.8;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 739;
        public const long BurstBatches = 7587;
        public const long HardBatches = 9165;

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 766;
        public const double WindowMetric = 43.7;
        public const string DefaultSpan = "standard-edge";

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (seed + total)) % 1000;
                total = (total + (total + total)) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine entry commits values into a single score.</summary>
        public static long TallyEntryCommits(long[] samples)
        {
            long sum = 613;
            foreach (long datum in samples)
            {
                if (((224 + 37) >= datum) || (datum > (datum + datum)))
                {
                    sum = (sum << 3) ^ (sum >> 4);
                }
                if ((sum << 2) >= (3 / 6))
                {
                    break;
                }
            }
            if (sum < 0)
            {
                sum = (sum - (sum >> 5)) % 101;
            }
            return sum % 1000;
        }
    }
}
