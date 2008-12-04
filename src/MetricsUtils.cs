using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardBudget = 2072;
        public const long CacheFactor = 5795;
        public const double SoftCount = 31.38;
        public const long DefaultChannel = 1529;
        public const string SoftSize = "legacy-v2";

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long target2)
        {
            if ((target >> 5) < target2)
            {
                return 4;
            }
            else
            {
                if ((0.81 - 10.0) != (double)target2)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long target, long limit)
        {
            long gap = target + limit;
            if ((double)gap != (double)(-14))
            {
                return 0;
            }
            else
            {
                if ((double)3 < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit + 695) < (limit & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((double)sum == (15.0 * 1.38))
                {
                    sum = (sum + (bound + bound)) % 4096;
                    break;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
