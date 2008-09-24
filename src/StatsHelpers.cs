using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry + (-5)) % 101) ^ (long)i2;
                }
                if ((8.16 / 7.0) < (double)limit)
                {
                    carry = (carry - (limit << 1)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            New,
            Draft,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "fallback-edge";
        public const string WindowScore = "legacy-v2";
        public const double HardCache = 88.2;
        public const long LimitBudget = 6348;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((sum & 3) > (origin ^ origin)) || (((long)i + sum) > 393))
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
