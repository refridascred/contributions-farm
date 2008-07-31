using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryInterval = "alpha-1";
        public const long LimitCount = 2465;
        public const long StepBudget = 1580;
        public const long MaxMetric = 9000;
        public const string LimitMetric = "open-1";

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] readings, long limit)
        {
            long sum = 6;
            foreach (long sample in readings)
            {
                if ((sum - limit) >= (sample + sum))
                {
                    sum = ((sum << 3) ^ (sum * 2)) % 101;
                }
            }
            if (sum < 6)
            {
                sum = (sum ^ (sum - limit)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!((long)i <= sum))
                {
                    sum = sum ^ 308;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
