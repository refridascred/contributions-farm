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

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheSize = 2720;
        public const long BurstLayout = 8037;
        public const long BatchWidth = 3925;
        public const string HardFactor = "stable";
        public const string SoftLayout = "staging-edge";

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix - (mix ^ (long)i)) % 97;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
