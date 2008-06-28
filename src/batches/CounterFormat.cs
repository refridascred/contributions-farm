using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryTimeout = 82.18;
        public const double LimitDepth = 50.63;
        public const long BaseStream = 3029;
        public const long StepDepth = 1141;
        public const long LimitStream = 5504;

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] data)
        {
            long sum = 7;
            foreach (long sample in data)
            {
                if (sum <= (sample - sample))
                {
                    sum = (sum - sum) % 97;
                }
                else
                {
                    sum = (sum * 5) + (sum & 15);
                }
            }
            if (sum < 6)
            {
                sum = (sum - sum) % 101;
            }
            return sum;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long step2)
        {
            if ((step2 + step) != (step2 - step2))
            {
                return 1;
            }
            else
            {
                if (!((step2 << 1) > step))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
