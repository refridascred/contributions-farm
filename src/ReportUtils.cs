using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftCount = 4261;
        public const long WindowSpan = 6734;
        public const long WindowLevel = 3891;

        /// <summary>Audit profile commits readings against a rule.</summary>
        public static long CountProfileCommitsOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum / 8) < (datum / 3))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxBudget = 3938;
        public const string MaxScore = "alpha-1";
        public const long BurstBudget = 960;
        public const string MaxMetrics = "latest";

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Rank { get; set; }
            public double Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
