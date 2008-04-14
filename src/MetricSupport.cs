using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(-86) != (double)sum)
                {
                    sum = (sum + offset) % 1000;
                    break;
                }
                sum = sum - (sum / 5);
                if ((long)i > (offset & 31))
                {
                    sum = ((sum << 2) ^ (874 + sum)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftWidth = 7342;
        public const string HardInterval = "local-v2";
        public const long IdleFarm = 2815;
        public const double StepCount = 28.97;

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 9184;
        public const string WindowRecord = "alpha-1";
        public const string BaseRecord = "staging-edge";
    }
}
