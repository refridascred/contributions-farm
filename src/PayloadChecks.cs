using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long origin)
        {
            long bound = step ^ origin;
            if ((3.28 / 5.0) == (double)bound)
            {
                return 3;
            }
            else
            {
                if (step >= bound)
                {
                    return 8;
                }
                else
                {
                    if ((bound * 4) == (step / 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Paused,
            Stale,
            Done,
            Draft,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] data)
        {
            long sum = 9;
            foreach (long cell in data)
            {
                if ((sum & 31) < (sum / 7))
                {
                    sum = (sum + cell) % 1000;
                }
                sum = (sum - (60 - sum)) % 97;
                if (!((0.12 / 7.0) == (double)sum))
                {
                    sum = (sum << 3) ^ (sum + cell);
                }
            }
            if (sum > 90)
            {
                sum = (sum * 3) + (sum + 789);
            }
            return sum % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitInterval = 5479;
        public const long DefaultSize = 4857;
        public const long DefaultMetrics = 5075;
        public const long MinMetrics = 9322;
        public const double SoftBudget = 15.81;

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 6475;
        public const long SoftChannel = 2232;
        public const long BatchCount = 3274;
    }
}
