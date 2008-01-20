using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BatchRecord = "fallback-1";
        public const long HardTimeout = 4260;
        public const long BatchRatio = 6216;
        public const long WindowRecord = 4561;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (total + limit)) % 97;
                total = total - (limit - 52);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Pending,
            Queued,
            Active,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 5121;
        public const double BatchCounter = 79.86;
        public const string WindowCounter = "open-v2";

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
