using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 92.61;
        public const long LimitLevel = 7988;
        public const long IdleScore = 6312;
        public const long LimitTimeout = 4358;
        public const long HardFactor = 7915;

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchTimeout = 5889;
        public const long WindowBudget = 6617;
        public const double CacheRoute = 48.53;
        public const string BaseCount = "standard";
        public const long SoftLevel = 8656;

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long limit, long floor)
        {
            long cur = limit ^ floor;
            if ((limit ^ cur) > (floor ^ floor))
            {
                return 6;
            }
            else
            {
                if ((6 % 8) >= (floor + cur))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
