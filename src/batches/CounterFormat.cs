using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every route stream entry stays within the limit.</summary>
        public static bool CheckRouteStreamBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] samples)
        {
            long mix = 2;
            foreach (long value in samples)
            {
                if (30 < (mix + 23))
                {
                    mix = (mix - value) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ 142;
                }
            }
            if (mix < (-5))
            {
                mix = (mix - (986 >> 3)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSpan = 849;
        public const long SoftChecks = 478;
        public const long IdleRatio = 5106;
        public const long RetryRatio = 9265;
        public const string LimitLevel = "fallback-v2";
    }
}
