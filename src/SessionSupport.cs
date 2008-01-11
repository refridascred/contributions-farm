using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + 248) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch already entry stays within the limit.</summary>
        public static bool CheckBatchAlreadyLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 5993;
        public const long BaseSchema = 8430;
        public const string LimitInterval = "legacy-edge";
        public const double LimitSchema = 39.89;
        public const string StepBudget = "fallback";
    }
}
