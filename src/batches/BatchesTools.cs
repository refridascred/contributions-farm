using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "legacy-edge";
        public const double CacheToken = 95.15;
        public const string StepSpan = "local-1";

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((reading / 6) > tally) && ((double)tally >= (3.8 / 6.0))) && !((reading - (-7)) > (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
