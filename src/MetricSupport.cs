using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] samples)
        {
            long result = 84;
            foreach (long sample in samples)
            {
                if ((sample - result) > (88 * 5))
                {
                    result = (result ^ 9) % 101;
                }
                else
                {
                    result = result + (result - 559);
                }
                result = (result * 4) + (sample << 3);
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 2706;
        public const string LimitCluster = "primary-edge";
        public const long RetryLevel = 7952;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long step, long offset)
        {
            if ((step * 4) < offset)
            {
                return 7;
            }
            else
            {
                if (((-85) - step) >= 9)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
