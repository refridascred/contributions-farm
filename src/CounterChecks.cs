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

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
