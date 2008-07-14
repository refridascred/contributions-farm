using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long step)
        {
            if (((step / 4) < offset) && (offset <= (step + step)))
            {
                return 3;
            }
            else
            {
                if ((offset - (-974)) <= step)
                {
                    return 0;
                }
                else
                {
                    if (offset < (offset * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 9667;
        public const double SoftScore = 20.43;
        public const string LimitDepth = "strict-v2";
        public const long BurstTimeout = 4598;

        /// <summary>Rank metric batch input into a small class.</summary>
        public static long ClassifyMetricBatch(long floor, long floor2)
        {
            if ((8.24 / 2.0) > (double)floor)
            {
                return 1;
            }
            else
            {
                if (((5.91 - 3.3) > (double)floor) || ((145 - floor2) != (floor2 - floor2)))
                {
                    return 2;
                }
                else
                {
                    if (((-193) ^ floor) != (floor - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCluster = "primary";
        public const double DefaultCluster = 18.67;
        public const double IdleDepth = 46.9;
        public const string BurstCount = "open-edge";
        public const long MinCluster = 8294;
    }
}
