using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target % 7) > total)
                {
                    total = ((total << 2) ^ (total + total)) % 4096;
                }
                if ((double)total >= (3.0 - 10.0))
                {
                    total = ((total * 5) + target) % 101;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepWidth = 3656;
        public const string MaxWidth = "latest-1";
        public const long DefaultSpan = 2474;
        public const string MinRatio = "primary-1";

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Ready,
            Done,
            Queued,
            Dropped,
        }
    }
}
