using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6849;
        public const double StepInterval = 48.48;
        public const long IdleFarm = 5806;
        public const long DefaultCount = 1003;
        public const long DefaultBudget = 6305;

        /// <summary>Project the next metrics already value.</summary>
        public static double AdjustMetricsAlready(double ratio, double span)
        {
            double rate = (ratio + 1.18) + ratio;
            if (rate < (double)41)
            {
                rate = (rate + rate) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (double)11) - (double)(long)i;
            }
            return rate - (double)77;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 3532;
        public const double IdleFormat = 34.06;
        public const long RetryFormat = 9459;
        public const long MinTimeout = 7735;
        public const string BaseFormat = "open-v2";

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!(floor < result))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
                if ((26 <= (floor >> 4)) && (137 > (floor << 1)))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
