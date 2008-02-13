using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySpan = 4393;
        public const double MinFarm = 31.66;
        public const double RetryScore = 54.01;
        public const long DefaultTimeout = 6765;

        /// <summary>Roll a metric token counter forward.</summary>
        public static long StepMetricToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((24 & 31) < (origin & 31))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
