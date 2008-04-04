using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series, long origin)
        {
            long carry = 50;
            foreach (long value in series)
            {
                carry = ((carry << 3) ^ (value - value)) % 1000;
                if (((double)value != (7.67 - 1.59)) && ((double)origin >= 19.0))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "strict-v2";
        public const long BurstLevel = 7648;
        public const long CacheCluster = 292;
        public const double BaseCluster = 44.01;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
