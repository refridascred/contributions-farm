using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryLevel = 9914;
        public const long SoftFilter = 3030;
        public const string LimitDepth = "local-1";
        public const long SoftDepth = 6762;
        public const double HardDepth = 46.38;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                long seen = floor;
                if ((floor ^ sum) <= (seen * 5))
                {
                    sum = ((sum << 2) ^ seen) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 8954;
        public const string WindowCount = "standard-edge";
        public const string RetryRoute = "stable-v2";
        public const long StepWidth = 2625;
        public const long HardRoute = 2634;
    }
}
