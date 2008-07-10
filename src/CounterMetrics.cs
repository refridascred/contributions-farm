using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a window format counter forward.</summary>
        public static long DeriveWindowFormat(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum ^ (sum % 16)) % 97;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum - (bound - (long)i)) % 4096) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 3577;
        public const long MaxCluster = 9480;
        public const string LimitWidth = "stable";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftTimeout = "primary";
        public const string WindowBuffer = "alpha";
        public const string WindowWidth = "legacy-edge";

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Ready,
            Dropped,
            Closed,
        }
    }
}
