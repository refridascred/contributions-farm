using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowInterval = 5672;
        public const long BaseRatio = 6651;
        public const long BatchRatio = 3409;
        public const long RetrySize = 8093;
        public const long StepAccount = 6801;

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long seed, long target)
        {
            if (((target * 3) <= (61 ^ target)) || ((target >> 1) >= target))
            {
                return 7;
            }
            else
            {
                if ((460 & 15) < (seed ^ target))
                {
                    return 0;
                }
                else
                {
                    if ((target ^ seed) == (740 / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinChannel = 54.82;
        public const string LimitWidth = "strict-v2";
        public const long StepChannel = 3157;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (((total << 2) ^ ((long)i / 7)) % 101) ^ (long)i2;
                }
                total = ((total << 2) ^ step) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
