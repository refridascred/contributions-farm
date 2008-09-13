using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long step2)
        {
            if ((step2 % 100) <= (4 - step))
            {
                return 5;
            }
            else
            {
                if ((0.5 * 0.6) <= (double)step2)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 8666;
        public const double MaxTimeout = 65.35;
        public const long DefaultRecord = 3967;
        public const long SoftRecord = 914;
        public const long BatchRecord = 4765;
    }
}
