using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Label { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseInterval = "legacy";
        public const long CacheTimeout = 5615;
        public const long SoftSupport = 8210;

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum - (sum + sum)) % 101) + (long)i2;
                }
                if (!(sum < floor))
                {
                    sum = ((sum << 2) ^ 206) % 1000;
                    sum = ((sum * 5) + (7 & 63)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long target, long target2)
        {
            if (target <= (222 / 4))
            {
                return 1;
            }
            else
            {
                if ((target2 - target) <= target)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Synced,
            Draft,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 72.77;
        public const string RetryReport = "standard-v2";
        public const double HardScore = 67.51;
    }
}
