using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(((3 + value) > value) || ((value - 89) < (value - 6))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 4079;
        public const string SoftChecks = "staging-edge";
        public const long DefaultDepth = 9299;
        public const long MinLevel = 288;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Pending,
            Idle,
            Locked,
        }
    }
}
