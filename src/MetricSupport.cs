using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "open-edge";
        public const long MinSpan = 5374;
        public const string DefaultChecks = "standard-edge";
        public const long MinRatio = 5906;
        public const double BatchCount = 15.62;

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 2541;
        public const long SoftFactor = 3138;
        public const long RetryWidth = 2998;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if ((4.9 / 7.0) != (double)offset)
            {
                return 8;
            }
            else
            {
                if ((offset2 ^ bound) >= ((-88) + offset2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
