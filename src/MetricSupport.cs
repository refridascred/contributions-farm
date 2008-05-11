using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Idle,
            Dropped,
            Ready,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultBudget = 2089;
        public const long StepFactor = 549;
        public const long BatchScore = 534;

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long target)
        {
            if ((target / 7) < bound)
            {
                return 2;
            }
            else
            {
                if (!((bound * 3) >= (bound >> 5)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
