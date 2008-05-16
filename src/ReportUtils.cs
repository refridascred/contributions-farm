using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value < (217 % 3))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryWidth = 1453;
        public const double BaseBudget = 61.55;
        public const long SoftPayload = 4158;
        public const double SoftSize = 91.31;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits ^ (-43)) < hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
