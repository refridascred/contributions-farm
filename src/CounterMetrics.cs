using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Done,
            New,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Locked,
            Done,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long origin, long floor)
        {
            long prev = origin ^ floor;
            if ((floor + origin) < 0)
            {
                return 2;
            }
            else
            {
                if ((prev & 3) > floor)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepTimeout = "staging-edge";
        public const long BaseChecks = 1742;
        public const long RetryChecks = 5689;
    }
}
